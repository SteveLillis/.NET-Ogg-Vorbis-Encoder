using System;
using System.Buffers.Binary;
using System.IO;
using NVorbis;
using Xunit;

namespace OggVorbisEncoder.Tests;

public class GranulePositionTests
{
    [Fact]
    public void EndOfStreamGranulePositionMatchesTotalSamples()
    {
        const int sampleRate = 44100;
        const int channels = 1;
        const int durationSeconds = 3;
        const int chunkSize = 512;

        int totalSamples = sampleRate * durationSeconds;
        float[][] samples = CreateSilence(channels, totalSamples);

        byte[] oggData = Encode(samples, sampleRate, channels, chunkSize);
        long granulePosition = ReadEndOfStreamGranulePosition(oggData);

        Assert.Equal(totalSamples, granulePosition);
    }

    [Fact]
    public void DecoderReadsExactSampleCount()
    {
        const int sampleRate = 44100;
        const int channels = 2;
        const int durationSeconds = 2;
        const int chunkSize = 512;

        int totalSamples = sampleRate * durationSeconds;
        float[][] samples = CreateSilence(channels, totalSamples);

        byte[] oggData = Encode(samples, sampleRate, channels, chunkSize);

        using var input = new MemoryStream(oggData);
        using var reader = new VorbisReader(input, false);

        Assert.Equal(sampleRate, reader.SampleRate);
        Assert.Equal(channels, reader.Channels);
        Assert.Equal(totalSamples, reader.TotalSamples);

        float[] buffer = new float[4096 * channels];

        while (reader.ReadSamples(buffer, 0, buffer.Length) > 0)
        {
        }

        Assert.Equal(reader.TotalSamples, reader.SamplePosition);
    }

    private static float[][] CreateSilence(int channels, int totalSamples)
    {
        var samples = new float[channels][];
        for (int ch = 0; ch < channels; ch++)
        {
            samples[ch] = new float[totalSamples];
        }

        return samples;
    }

    private static byte[] Encode(float[][] samples, int sampleRate, int channels, int chunkSize)
    {
        using var output = new MemoryStream();

        var info = VorbisInfo.InitVariableBitRate(channels, sampleRate, 0.5f);
        var oggStream = new OggStream(1);

        var comments = new Comments();
        var infoPacket = HeaderPacketBuilder.BuildInfoPacket(info);
        var commentsPacket = HeaderPacketBuilder.BuildCommentsPacket(comments);
        var booksPacket = HeaderPacketBuilder.BuildBooksPacket(info);

        oggStream.PacketIn(infoPacket);
        oggStream.PacketIn(commentsPacket);
        oggStream.PacketIn(booksPacket);

        FlushPages(oggStream, output, true);

        var processingState = ProcessingState.Create(info);

        int totalSamples = samples[0].Length;
        int index = 0;

        while (index < totalSamples)
        {
            int length = Math.Min(chunkSize, totalSamples - index);
            processingState.WriteData(samples, length, index);

            while (!oggStream.Finished && processingState.PacketOut(out OggPacket packet))
            {
                oggStream.PacketIn(packet);
                FlushPages(oggStream, output, false);
            }

            index += length;
        }

        processingState.WriteEndOfStream();

        while (!oggStream.Finished && processingState.PacketOut(out OggPacket packet))
        {
            oggStream.PacketIn(packet);
            FlushPages(oggStream, output, false);
        }

        FlushPages(oggStream, output, true);

        return output.ToArray();
    }

    private static long ReadEndOfStreamGranulePosition(byte[] data)
    {
        long? endOfStreamGranulePosition = null;
        int index = 0;

        while (index + 27 <= data.Length)
        {
            if (data[index] != (byte)'O' ||
                data[index + 1] != (byte)'g' ||
                data[index + 2] != (byte)'g' ||
                data[index + 3] != (byte)'S')
            {
                throw new InvalidDataException($"Expected OggS capture pattern at byte {index}.");
            }

            byte headerType = data[index + 5];
            long granulePosition = BinaryPrimitives.ReadInt64LittleEndian(data.AsSpan(index + 6, 8));

            int segmentCount = data[index + 26];
            int segmentTableStart = index + 27;
            int bodySize = 0;

            for (int i = 0; i < segmentCount; i++)
            {
                bodySize += data[segmentTableStart + i];
            }

            int pageSize = 27 + segmentCount + bodySize;

            if ((headerType & 0x04) != 0)
            {
                endOfStreamGranulePosition = granulePosition;
            }

            index += pageSize;
        }

        if (endOfStreamGranulePosition == null)
        {
            throw new InvalidDataException("No end-of-stream page found.");
        }

        return endOfStreamGranulePosition.Value;
    }

    private static void FlushPages(OggStream oggStream, Stream output, bool force)
    {
        while (oggStream.PageOut(out OggPage page, force))
        {
            output.Write(page.Header, 0, page.Header.Length);
            output.Write(page.Body, 0, page.Body.Length);
        }
    }
}
