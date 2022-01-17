using System;
using System.IO;

namespace OggVorbisEncoder.Example;

public class Encoder
{
    private static readonly int WriteBufferSize = 512;
    private static readonly int[] SampleRates = { 8000, 11025, 16000, 22050, 32000, 44100 };

    [STAThread]
    private static void Main()
    {
        ConvertPCMFile();
    }

    private static void ConvertPCMFile()
    {
        var pcmBytes = File.ReadAllBytes("unencoded.raw");
        var oggBytes = ConvertRawPCMFile(44100, 2, pcmBytes, PcmSample.SixteenBit, 44100, 2);
        File.WriteAllBytes("encoded.ogg", oggBytes);
    }

    private static void GenerateTestFiles()
    {
        int frequency = 1000;

        for (int channels = 1; channels <= 2; channels++)
        {
            foreach (var sampleRate in SampleRates)
            {
                try
                {
                    var sineBytes = GenerateSineWaveFile(sampleRate, channels, frequency, 10.0f);
                    File.WriteAllBytes($"C:/Temp/Sine_{sampleRate}_{frequency}hz_{channels}.ogg", sineBytes);
                    Console.WriteLine($"{sampleRate} samples/s, {channels} channels succeeded.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{sampleRate} samples/s, {channels} channels failed. {ex.Message}");
                }
            }
        }
        Console.WriteLine("Done!");
        Console.ReadLine();
    }

    private static byte[] ConvertRawPCMFile(int outputSampleRate, int outputChannels, byte[] pcmSamples, PcmSample pcmSampleSize, int pcmSampleRate, int pcmChannels)
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

    private static byte[] GenerateSineWaveFile(int outputSampleRate, int outputChannels, int frequency, float durationSeconds, float volume = 0.2f)
    {
        float[][] outSamples = new float[outputChannels][];

        int numOutputSamples = (int)(durationSeconds * outputSampleRate);
        //Ensure that samble buffer is aligned to write chunk size
        numOutputSamples = (numOutputSamples / WriteBufferSize) * WriteBufferSize;

        for (int ch = 0; ch < outputChannels; ch++)
        {
            outSamples[ch] = new float[numOutputSamples];
        }

        for (int i = 0; i < numOutputSamples; i++)
        {
            var sample = volume * SineSample(i, frequency, outputSampleRate);
            for (int ch = 0; ch < outputChannels; ch++)
                outSamples[ch][i] = sample;
        }

        return GenerateFile(outSamples, outputSampleRate, outputChannels);
    }

    private static byte[] GenerateFile(float[][] floatSamples, int sampleRate, int channels)
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

    private static float SineSample(int sample, float frequency, int sampleRate)
    {
        float sampleT = ((float)sample) / sampleRate;
        return MathF.Sin(sampleT * MathF.PI * 2.0f * frequency);
    }

    private static float ByteToSample(short pcmValue)
    {
        return pcmValue / 128f;
    }

    private static float ShortToSample(short pcmValue)
    {
        return pcmValue / 32768f;
    }

    /// <summary>
    /// We cheat on the WAV header; we just bypass the header and never
    /// verify that it matches 16bit/stereo/44.1kHz.This is just an
    /// example, after all.
    /// </summary>
    private static void StripWavHeader(BinaryReader stdin)
    {
        var tempBuffer = new byte[6];
        for (var i = 0; (i < 30) && (stdin.Read(tempBuffer, 0, 2) > 0); i++)
        {
            if ((tempBuffer[0] == 'd') && (tempBuffer[1] == 'a'))
            {
                stdin.Read(tempBuffer, 0, 6);
                break;
            }
        }
    }

    enum PcmSample : int
    {
        EightBit = 1,
        SixteenBit = 2
    }
}
