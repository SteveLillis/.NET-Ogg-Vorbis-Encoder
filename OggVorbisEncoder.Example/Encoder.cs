using System;
using System.IO;

namespace OggVorbisEncoder.Example
{
    public class Encoder
    {
        private static int WriteBufferSize = 512;
        private static readonly int[] SampleRates = { 8000, 11025, 16000, 22050, 32000, 44100 };

        [STAThread]
        private static void Main()
        {
            ConvertPCMFile();
        }

        private static void ConvertPCMFile()
        {
            var pcmBytes = File.ReadAllBytes("unencoded.raw");
            var oggBytes = ConvertRawPCMFile(44100, 2, pcmBytes, PCMSample.SixteenBit, 44100, 2);
            File.WriteAllBytes("encoded.ogg", oggBytes);
        }

        private static void GenerateTestFiles()
        {
            int Frequency = 1000;

            for (int Channels = 1; Channels <= 2; Channels++)
            {
                foreach (var sampleRate in SampleRates)
                {
                    try
                    {
                        var sineBytes = GenerateSineWaveFile(sampleRate, Channels, Frequency, 10.0f);
                        File.WriteAllBytes($"C:/Temp/Sine_{sampleRate}_{Frequency}hz_{Channels}.ogg", sineBytes);
                        Console.WriteLine($"{sampleRate} samples/s, {Channels} channels succeeded.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{sampleRate} samples/s, {Channels} channels failed. {ex.Message}");
                    }
                }
            }
            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        private static byte[] ConvertRawPCMFile(int OutputSampleRate, int OutputChannels, byte[] PCMSamples, PCMSample PCMSampleSize, int PCMSampleRate, int PCMChannels)
        {
            int NumPCMSamples = (PCMSamples.Length / (int)PCMSampleSize / PCMChannels);
            float PCMDuraton = NumPCMSamples / (float)PCMSampleRate;

            int NumOutputSamples = (int)(PCMDuraton * OutputSampleRate);
            //Ensure that samble buffer is aligned to write chunk size
            NumOutputSamples = (NumOutputSamples / WriteBufferSize) * WriteBufferSize;

            float[][] OutSamples = new float[OutputChannels][];

            for (int ch = 0; ch < OutputChannels; ch++)
                OutSamples[ch] = new float[NumOutputSamples];

            for(int sampleNumber = 0; sampleNumber < NumOutputSamples; sampleNumber++)
            {
                float rawSample = 0.0f;

                for (int ch = 0; ch < OutputChannels; ch++)
                {
                    int sampleIndex = (sampleNumber * PCMChannels) * (int)PCMSampleSize;

                    if (ch < PCMChannels) sampleIndex += (ch * (int)PCMSampleSize);
                    
                    switch (PCMSampleSize)
                    {
                        case PCMSample.EightBit:
                            rawSample = ByteToSample(PCMSamples[sampleIndex]);
                            break;
                        case PCMSample.SixteenBit:
                            rawSample = ShortToSample((short)(PCMSamples[sampleIndex + 1] << 8 | PCMSamples[sampleIndex]));
                            break;
                    }

                    OutSamples[ch][sampleNumber] = rawSample;
                }
            }

            return GenerateFile(OutSamples, OutputSampleRate, OutputChannels);
        }

        private static byte[] GenerateSineWaveFile(int OutputSampleRate, int OutputChannels, int Frequency, float DurationSeconds, float Volume = 0.2f)
        {
            float[][] OutSamples = new float[OutputChannels][];

            int NumOutputSamples = (int)(DurationSeconds * OutputSampleRate);
            //Ensure that samble buffer is aligned to write chunk size
            NumOutputSamples = (NumOutputSamples / WriteBufferSize) * WriteBufferSize;

            for (int ch = 0; ch < OutputChannels; ch++)
                OutSamples[ch] = new float[NumOutputSamples];

            for (int i = 0; i < NumOutputSamples; i++)
            {
                var sample = Volume * SineSample(i, Frequency, OutputSampleRate);
                for (int ch = 0; ch < OutputChannels; ch++)
                    OutSamples[ch][i] = sample;
            }

            return GenerateFile(OutSamples, OutputSampleRate, OutputChannels);
        }

        private static byte[] GenerateFile(float[][] FloatSamples, int SampleRate, int Channels)
        {
            using (MemoryStream outputData = new MemoryStream())
            {
                // Stores all the static vorbis bitstream settings
                var info = VorbisInfo.InitVariableBitRate(Channels, SampleRate, 0.5f);

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
                var headerBuilder = new HeaderPacketBuilder();

                var comments = new Comments();
                comments.AddTag("ARTIST", "TEST");

                var infoPacket = headerBuilder.BuildInfoPacket(info);
                var commentsPacket = headerBuilder.BuildCommentsPacket(comments);
                var booksPacket = headerBuilder.BuildBooksPacket(info);

                oggStream.PacketIn(infoPacket);
                oggStream.PacketIn(commentsPacket);
                oggStream.PacketIn(booksPacket);

                // Flush to force audio data onto its own page per the spec
                FlushPages(oggStream, outputData, true);

                // =========================================================
                // BODY (Audio Data)
                // =========================================================
                var processingState = ProcessingState.Create(info);
                
                for (int readIndex = 0; readIndex <= FloatSamples[0].Length; readIndex += WriteBufferSize)
                {
                    if(readIndex == FloatSamples[0].Length)
                    {
                        processingState.WriteEndOfStream();
                    }
                    else
                    {
                        processingState.WriteData(FloatSamples, WriteBufferSize, readIndex);
                    }

                    OggPacket packet;
                    while (!oggStream.Finished
                            && processingState.PacketOut(out packet))
                    {
                        oggStream.PacketIn(packet);

                        FlushPages(oggStream, outputData, false);
                    }
                }

                FlushPages(oggStream, outputData, true);

                return outputData.ToArray();
            }
        }

        private static void FlushPages(OggStream oggStream, Stream Output, bool Force)
        {
            OggPage page;
            while (oggStream.PageOut(out page, Force))
            {
                Output.Write(page.Header, 0, page.Header.Length);
                Output.Write(page.Body, 0, page.Body.Length);
            }
        }

        private static float SineSample(int sample, float frequency, int samplerate)
        {
            float sampleT = ((float)sample) / samplerate;
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
        ///     We cheat on the WAV header; we just bypass the header and never
        ///     verify that it matches 16bit/stereo/44.1kHz.This is just an
        ///     example, after all.
        /// </summary>
        private static void StripWavHeader(BinaryReader stdin)
        {
            var tempBuffer = new byte[6];
            for (var i = 0; (i < 30) && (stdin.Read(tempBuffer, 0, 2) > 0); i++)
                if ((tempBuffer[0] == 'd') && (tempBuffer[1] == 'a'))
                {
                    stdin.Read(tempBuffer, 0, 6);
                    break;
                }
        }

        enum PCMSample : int
        {
            EightBit = 1,
            SixteenBit = 2
        }
    }
}