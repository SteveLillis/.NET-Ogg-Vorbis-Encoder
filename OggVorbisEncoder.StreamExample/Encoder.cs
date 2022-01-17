using System;
using System.IO;

namespace OggVorbisEncoder.Example2
{
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
            using (Stream inputStream = File.OpenRead("unencoded.raw"))
            {
                using (Stream outputStream = File.Create("encoded.ogg"))
                {
                    ConvertPCMToOggVorbis(inputStream, outputStream, 44100, 2, PcmSample.SixteenBit, 44100, 2);
                }
            }
        }

        private static void ConvertPCMToOggVorbis(Stream inputStream, Stream outputStream, int outputSampleRate, int outputChannels, PcmSample pcmSampleSize, int pcmSampleRate, int pcmChannels)
        {
            byte[] pcm = new byte[WriteBufferSize];

            InitOggStream(outputSampleRate, outputChannels, out OggStream oggStream, out ProcessingState processingState);

            while (true)
            {
                int chunkSize = inputStream.Read(pcm, 0, WriteBufferSize);
                if (chunkSize <= 0)
                    break;

                int numPcmSamples = chunkSize / (int)pcmSampleSize / pcmChannels;
                float pcmDuraton = numPcmSamples / (float)pcmSampleRate;

                int numOutputSamples = (int)(pcmDuraton * outputSampleRate);

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

                        if (ch < pcmChannels)
                            sampleIndex += ch * (int)pcmSampleSize;

                        switch (pcmSampleSize)
                        {
                            case PcmSample.EightBit:
                                rawSample = ByteToSample(pcm[sampleIndex]);
                                break;
                            default:
                            case PcmSample.SixteenBit:
                                rawSample = ShortToSample((short)(pcm[sampleIndex + 1] << 8 | pcm[sampleIndex]));
                                break;
                        }

                        outSamples[ch][sampleNumber] = rawSample;
                    }
                }

                FlushPages(oggStream, outputStream, false);
                ProcessChunk(outSamples, processingState, oggStream, numOutputSamples);
            }

            FlushPages(oggStream, outputStream, true);
        }

        private static void ProcessChunk(float[][] floatSamples, ProcessingState processingState, OggStream oggStream, int writeBufferSize)
        {
            processingState.WriteData(floatSamples, writeBufferSize, 0);

            while (!oggStream.Finished && processingState.PacketOut(out OggPacket packet))
            {
                oggStream.PacketIn(packet);
            }
        }

        private static void InitOggStream(int sampleRate, int channels, out OggStream oggStream, out ProcessingState processingState)
        {
            // Stores all the static vorbis bitstream settings
            var info = VorbisInfo.InitVariableBitRate(channels, sampleRate, 0.5f);

            // set up our packet->stream encoder
            var serial = new Random().Next();
            oggStream = new OggStream(serial);

            // =========================================================
            // HEADER
            // =========================================================
            // Vorbis streams begin with three headers; the initial header (with
            // most of the codec setup parameters) which is mandated by the Ogg
            // bitstream spec.  The second header holds any comment fields.  The
            // third header holds the bitstream codebook.
            var comments = new Comments();
            comments.AddTag("ARTIST", "TTS");

            var infoPacket = HeaderPacketBuilder.BuildInfoPacket(info);
            var commentsPacket = HeaderPacketBuilder.BuildCommentsPacket(comments);
            var booksPacket = HeaderPacketBuilder.BuildBooksPacket(info);

            oggStream.PacketIn(infoPacket);
            oggStream.PacketIn(commentsPacket);
            oggStream.PacketIn(booksPacket);

            // =========================================================
            // BODY (Audio Data)
            // =========================================================
            processingState = ProcessingState.Create(info);
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
}