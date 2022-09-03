using U0 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter0;
using U1 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter1;
using U2 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter2;

namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled;

class Blocks
{
    public class Block0 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new U0.Page1_0()},
            new IStaticCodeBook[] {null, null, new U0.Page2_0()},
            new IStaticCodeBook[] {null, null, new U0.Page3_0()},
            new IStaticCodeBook[] {null, null, new U0.Page4_0()},
            new IStaticCodeBook[] {null, null, new U0.Page5_0()},
            new IStaticCodeBook[] {new U0.Page6_0(), new U0.Page6_1()},
            new IStaticCodeBook[] {new U0.Page7_0(), new U0.Page7_1(), new U0.Page7_2()}
        };
    }

    public class Block1 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new U1.Page1_0()},
            new IStaticCodeBook[] {null, null, new U1.Page2_0()},
            new IStaticCodeBook[] {null, null, new U1.Page3_0()},
            new IStaticCodeBook[] {null, null, new U1.Page4_0()},
            new IStaticCodeBook[] {null, null, new U1.Page5_0()},
            new IStaticCodeBook[] {null, null, new U1.Page6_0()},
            new IStaticCodeBook[] {new U1.Page7_0(), new U1.Page7_1()},
            new IStaticCodeBook[] {new U1.Page8_0(), new U1.Page8_1()},
            new IStaticCodeBook[] {new U1.Page9_0(), new U1.Page9_1(), new U1.Page9_2()}
        };
    }

    public class Block2 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new U2.Page1_0()},
            new IStaticCodeBook[] {null, null, new U2.Page2_0()},
            new IStaticCodeBook[] {null, null, new U2.Page3_0()},
            new IStaticCodeBook[] {null, null, new U2.Page4_0()},
            new IStaticCodeBook[] {new U2.Page5_0(), new U2.Page5_1()},
            new IStaticCodeBook[] {new U2.Page6_0(), new U2.Page6_1()},
            new IStaticCodeBook[] {new U2.Page7_0(), new U2.Page7_1()},
            new IStaticCodeBook[] {new U2.Page8_0(), new U2.Page8_1()},
            new IStaticCodeBook[] {new U2.Page9_0(), new U2.Page9_1(), new U2.Page9_2()}
        };
    }
}
