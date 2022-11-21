using System;
using System.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

namespace OggVorbisEncoder.Benchmarks;

[MemoryDiagnoser]
[SimpleJob(RuntimeMoniker.NetCoreApp31)]
[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.Net70)]
public class EncoderBenchmarks
{
    private readonly int WriteBufferSize = 512;
    private readonly byte[] pcmBytes;

    public EncoderBenchmarks()
    {
        pcmBytes = File.ReadAllBytes("unencoded-30s.raw");
    }

    [Benchmark]
    public byte[] ConvertPCMFile() => ConvertRawPCMFile(44100, 2, pcmBytes, PcmSample.SixteenBit, 44100, 2);

    private byte[] ConvertRawPCMFile(int outputSampleRate, int outputChannels, byte[] pcmSamples, PcmSample pcmSampleSize, int pcmSampleRate, int pcmChannels)
    {
        int numPcmSamples = (pcmSamples.Length / (int)pcmSampleSize / pcmChannels);
        float pcmDuraton = numPcmSamples / (float)pcmSampleRate;

        int numOutputSamples = (int)(pcmDuraton * outputSampleRate);
        //Ensure that samble buffer is aligned to write chunk size
        numOutputSamples = (numOutputSamples / WriteBufferSize) * WriteBufferSize;

        float[][] outSamples = new float[outputChannels][];

        for (int ch = 0; ch < outputChannels; ch++)
        {
            outSamples[ch] = new float[numOutputSamples];
        }

        for (int sampleNumber = 0; sampleNumber < numOutputSamples; sampleNumber++)
        {
            float rawSample = 0.0f;

            for (int ch = 0; ch < outputChannels; ch++)
            {
                int sampleIndex = (sampleNumber * pcmChannels) * (int)pcmSampleSize;

                if (ch < pcmChannels) sampleIndex += (ch * (int)pcmSampleSize);

                switch (pcmSampleSize)
                {
                    case PcmSample.EightBit:
                        rawSample = ByteToSample(pcmSamples[sampleIndex]);
                        break;
                    case PcmSample.SixteenBit:
                        rawSample = ShortToSample((short)(pcmSamples[sampleIndex + 1] << 8 | pcmSamples[sampleIndex]));
                        break;
                }

                outSamples[ch][sampleNumber] = rawSample;
            }
        }

        return GenerateFile(outSamples, outputSampleRate, outputChannels);
    }

    private byte[] GenerateFile(float[][] floatSamples, int sampleRate, int channels)
    {
        using MemoryStream outputData = new MemoryStream();

        // Stores all the static vorbis bitstream settings
        var info = VorbisInfo.InitVariableBitRate(channels, sampleRate, 0.5f);

        // set up our packet->stream encoder
        var serial = new Random().Next();
        var oggStream = new OggStream(serial);

        // =========================================================
        // HEADER
        // =========================================================
        // Vorbis streams begin with three headers; the initial header (with
        // most of the codec setup parameters) which is mandated by the Ogg
        // bitstream spec.  The second header holds any comment fields.  The
        // third header holds the bitstream codebook.

        var comments = new Comments();
        comments.AddTag("ARTIST", "TEST");

        var infoPacket = HeaderPacketBuilder.BuildInfoPacket(info);
        var commentsPacket = HeaderPacketBuilder.BuildCommentsPacket(comments);
        var booksPacket = HeaderPacketBuilder.BuildBooksPacket(info);

        oggStream.PacketIn(infoPacket);
        oggStream.PacketIn(commentsPacket);
        oggStream.PacketIn(booksPacket);

        // Flush to force audio data onto its own page per the spec
        FlushPages(oggStream, outputData, true);

        // =========================================================
        // BODY (Audio Data)
        // =========================================================
        var processingState = ProcessingState.Create(info);

        for (int readIndex = 0; readIndex <= floatSamples[0].Length; readIndex += WriteBufferSize)
        {
            if (readIndex == floatSamples[0].Length)
            {
                processingState.WriteEndOfStream();
            }
            else
            {
                processingState.WriteData(floatSamples, WriteBufferSize, readIndex);
            }

            while (!oggStream.Finished && processingState.PacketOut(out OggPacket packet))
            {
                oggStream.PacketIn(packet);

                FlushPages(oggStream, outputData, false);
            }
        }

        FlushPages(oggStream, outputData, true);

        return outputData.ToArray();
    }

    private static void FlushPages(OggStream oggStream, Stream output, bool force)
    {
        while (oggStream.PageOut(out OggPage page, force))
        {
            output.Write(page.Header, 0, page.Header.Length);
            output.Write(page.Body, 0, page.Body.Length);
        }
    }

    private static float ByteToSample(short pcmValue)
    {
        return pcmValue / 128f;
    }

    private static float ShortToSample(short pcmValue)
    {
        return pcmValue / 32768f;
    }

    enum PcmSample : int
    {
        EightBit = 1,
        SixteenBit = 2
    }
}

public class Program
{
    public static void Main()
    {
        var summary = BenchmarkRunner.Run<EncoderBenchmarks>();
    }
}
