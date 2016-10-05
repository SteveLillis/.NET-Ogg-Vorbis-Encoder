using System;
using System.IO;

namespace OggVorbisEncoder.Example
{
    public class Encoder
    {
        private const int SampleSize = 1024;

        [STAThread]
        private static void Main()
        {
            var stdin = new FileStream(@"unencoded.raw", FileMode.Open, FileAccess.Read);
            var stdout = new FileStream(@"encoded.ogg", FileMode.Create, FileAccess.Write);

            // StripWavHeader(stdin);

            // Stores all the static vorbis bitstream settings
            var info = VorbisInfo.InitVariableBitRate(2, 44100, 0.1f);

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
            OggPage page;
            while (oggStream.PageOut(out page, true))
            {
                stdout.Write(page.Header, 0, page.Header.Length);
                stdout.Write(page.Body, 0, page.Body.Length);
            }

            // =========================================================
            // BODY (Audio Data)
            // =========================================================
            var processingState = ProcessingState.Create(info);

            var buffer = new float[info.Channels][];
            buffer[0] = new float[SampleSize];
            buffer[1] = new float[SampleSize];

            var readbuffer = new byte[SampleSize*4];
            while (!oggStream.Finished)
            {
                var bytes = stdin.Read(readbuffer, 0, readbuffer.Length);

                if (bytes == 0)
                {
                    processingState.WriteEndOfStream();
                }
                else
                {
                    var samples = bytes/4;

                    for (var i = 0; i < samples; i++)
                    {
                        // uninterleave samples
                        buffer[0][i] = (short) ((readbuffer[i*4 + 1] << 8) | (0x00ff & readbuffer[i*4]))/32768f;
                        buffer[1][i] = (short) ((readbuffer[i*4 + 3] << 8) | (0x00ff & readbuffer[i*4 + 2]))/32768f;
                    }

                    processingState.WriteData(buffer, samples);
                }

                OggPacket packet;
                while (!oggStream.Finished
                       && processingState.PacketOut(out packet))
                {
                    oggStream.PacketIn(packet);

                    while (!oggStream.Finished
                           && oggStream.PageOut(out page, false))
                    {
                        stdout.Write(page.Header, 0, page.Header.Length);
                        stdout.Write(page.Body, 0, page.Body.Length);
                    }
                }
            }

            stdin.Close();
            stdout.Close();
        }

        /// <summary>
        ///     we cheat on the WAV header; we just bypass the header and never
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
    }
}