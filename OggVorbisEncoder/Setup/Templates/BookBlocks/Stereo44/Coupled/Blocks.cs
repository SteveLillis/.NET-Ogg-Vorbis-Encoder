using CN1 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ChapterNeg1;
using C0 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter0;
using C1 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter1;
using C2 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter2;
using C3 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter3;
using C4 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter4;
using C5 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter5;
using C6 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter6;
using C7 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter7;
using C8 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter8;
using C9 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter9;

using MCN1 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapterNeg1;
using MC0 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapter0;
using MC1 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapter1;

namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled;

public class Blocks
{
    public class BlockNeg1 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new CN1.Page1_0()},
            new IStaticCodeBook[] {null, null, new CN1.Page2_0()},
            new IStaticCodeBook[] {null, null, new CN1.Page3_0()},
            new IStaticCodeBook[] {null, null, new CN1.Page4_0()},
            new IStaticCodeBook[] {null, null, new CN1.Page5_0()},
            new IStaticCodeBook[] {new CN1.Page6_0(), new CN1.Page6_1()},
            new IStaticCodeBook[] {new CN1.Page7_0(), new CN1.Page7_1()},
            new IStaticCodeBook[] {new CN1.Page8_0(), new CN1.Page8_1(), new CN1.Page8_2()}
        };
    }

    public class Block0 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new C0.Page1_0()},
            new IStaticCodeBook[] {null, null, new C0.Page2_0()},
            new IStaticCodeBook[] {null, null, new C0.Page3_0()},
            new IStaticCodeBook[] {null, null, new C0.Page4_0()},
            new IStaticCodeBook[] {null, null, new C0.Page5_0()},
            new IStaticCodeBook[] {new C0.Page6_0(), new C0.Page6_1()},
            new IStaticCodeBook[] {new C0.Page7_0(), new C0.Page7_1()},
            new IStaticCodeBook[] {new C0.Page8_0(), new C0.Page8_1(), new C0.Page8_2()}
        };
    }

    public class Block1 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new C1.Page1_0()},
            new IStaticCodeBook[] {null, null, new C1.Page2_0()},
            new IStaticCodeBook[] {null, null, new C1.Page3_0()},
            new IStaticCodeBook[] {null, null, new C1.Page4_0()},
            new IStaticCodeBook[] {null, null, new C1.Page5_0()},
            new IStaticCodeBook[] {new C1.Page6_0(), new C1.Page6_1()},
            new IStaticCodeBook[] {new C1.Page7_0(), new C1.Page7_1()},
            new IStaticCodeBook[] {new C1.Page8_0(), new C1.Page8_1(), new C1.Page8_2()}
        };
    }

    public class Block2 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new C2.Page1_0()},
            new IStaticCodeBook[] {null, null, new C2.Page2_0()},
            new IStaticCodeBook[] {null, null, new C2.Page3_0()},
            new IStaticCodeBook[] {null, null, new C2.Page4_0()},
            new IStaticCodeBook[] {null, null, new C2.Page5_0()},
            new IStaticCodeBook[] {null, null, new C2.Page6_0()},
            new IStaticCodeBook[] {new C2.Page7_0(), new C2.Page7_1()},
            new IStaticCodeBook[] {new C2.Page8_0(), new C2.Page8_1()},
            new IStaticCodeBook[] {new C2.Page9_0(), new C2.Page9_1(), new C2.Page9_2()}
        };
    }

    public class Block3 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new C3.Page1_0()},
            new IStaticCodeBook[] {null, null, new C3.Page2_0()},
            new IStaticCodeBook[] {null, null, new C3.Page3_0()},
            new IStaticCodeBook[] {null, null, new C3.Page4_0()},
            new IStaticCodeBook[] {null, null, new C3.Page5_0()},
            new IStaticCodeBook[] {null, null, new C3.Page6_0()},
            new IStaticCodeBook[] {new C3.Page7_0(), new C3.Page7_1()},
            new IStaticCodeBook[] {new C3.Page8_0(), new C3.Page8_1()},
            new IStaticCodeBook[] {new C3.Page9_0(), new C3.Page9_1(), new C3.Page9_2()}
        };
    }

    public class Block4 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new C4.Page1_0()},
            new IStaticCodeBook[] {null, null, new C4.Page2_0()},
            new IStaticCodeBook[] {null, null, new C4.Page3_0()},
            new IStaticCodeBook[] {null, null, new C4.Page4_0()},
            new IStaticCodeBook[] {null, null, new C4.Page5_0()},
            new IStaticCodeBook[] {null, null, new C4.Page6_0()},
            new IStaticCodeBook[] {new C4.Page7_0(), new C4.Page7_1()},
            new IStaticCodeBook[] {new C4.Page8_0(), new C4.Page8_1()},
            new IStaticCodeBook[] {new C4.Page9_0(), new C4.Page9_1(), new C4.Page9_2()}
        };
    }

    public class Block5 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new C5.Page1_0()},
            new IStaticCodeBook[] {null, null, new C5.Page2_0()},
            new IStaticCodeBook[] {null, null, new C5.Page3_0()},
            new IStaticCodeBook[] {null, null, new C5.Page4_0()},
            new IStaticCodeBook[] {null, null, new C5.Page5_0()},
            new IStaticCodeBook[] {null, null, new C5.Page6_0()},
            new IStaticCodeBook[] {new C5.Page7_0(), new C5.Page7_1()},
            new IStaticCodeBook[] {new C5.Page8_0(), new C5.Page8_1()},
            new IStaticCodeBook[] {new C5.Page9_0(), new C5.Page9_1(), new C5.Page9_2()}
        };
    }

    public class Block6 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new C6.Page1_0()},
            new IStaticCodeBook[] {null, null, new C6.Page2_0()},
            new IStaticCodeBook[] {null, null, new C6.Page3_0()},
            new IStaticCodeBook[] {null, null, new C6.Page4_0()},
            new IStaticCodeBook[] {new C6.Page5_0(), new C6.Page5_1()},
            new IStaticCodeBook[] {new C6.Page6_0(), new C6.Page6_1()},
            new IStaticCodeBook[] {new C6.Page7_0(), new C6.Page7_1()},
            new IStaticCodeBook[] {new C6.Page8_0(), new C6.Page8_1()},
            new IStaticCodeBook[] {new C6.Page9_0(), new C6.Page9_1(), new C6.Page9_2()}
        };
    }

    public class Block7 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new C7.Page1_0()},
            new IStaticCodeBook[] {null, null, new C7.Page2_0()},
            new IStaticCodeBook[] {null, null, new C7.Page3_0()},
            new IStaticCodeBook[] {null, null, new C7.Page4_0()},
            new IStaticCodeBook[] {new C7.Page5_0(), new C7.Page5_1()},
            new IStaticCodeBook[] {new C7.Page6_0(), new C7.Page6_1()},
            new IStaticCodeBook[] {new C7.Page7_0(), new C7.Page7_1()},
            new IStaticCodeBook[] {new C7.Page8_0(), new C7.Page8_1()},
            new IStaticCodeBook[] {new C7.Page9_0(), new C7.Page9_1(), new C7.Page9_2()}
        };
    }

    public class Block8 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new C8.Page1_0()},
            new IStaticCodeBook[] {null, null, new C8.Page2_0()},
            new IStaticCodeBook[] {null, null, new C8.Page3_0()},
            new IStaticCodeBook[] {null, null, new C8.Page4_0()},
            new IStaticCodeBook[] {new C8.Page5_0(), new C8.Page5_1()},
            new IStaticCodeBook[] {new C8.Page6_0(), new C8.Page6_1()},
            new IStaticCodeBook[] {new C8.Page7_0(), new C8.Page7_1()},
            new IStaticCodeBook[] {new C8.Page8_0(), new C8.Page8_1()},
            new IStaticCodeBook[] {new C8.Page9_0(), new C8.Page9_1(), new C8.Page9_2()}
        };
    }

    public class Block9 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new C9.Page1_0()},
            new IStaticCodeBook[] {null, null, new C9.Page2_0()},
            new IStaticCodeBook[] {null, null, new C9.Page3_0()},
            new IStaticCodeBook[] {null, null, new C9.Page4_0()},
            new IStaticCodeBook[] {new C9.Page5_0(), new C9.Page5_1()},
            new IStaticCodeBook[] {new C9.Page6_0(), new C9.Page6_1()},
            new IStaticCodeBook[] {new C9.Page7_0(), new C9.Page7_1()},
            new IStaticCodeBook[] {new C9.Page8_0(), new C9.Page8_1()},
            new IStaticCodeBook[] {new C9.Page9_0(), new C9.Page9_1(), new C9.Page9_2()}
        };
    }




    public class ManagedBlockNeg1 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new MCN1.Page1_0()},
            new IStaticCodeBook[] {null, null, new MCN1.Page2_0()},
            new IStaticCodeBook[] {null, null, new MCN1.Page3_0()},
            new IStaticCodeBook[] {null, null, new MCN1.Page4_0()},
            new IStaticCodeBook[] {null, null, new MCN1.Page5_0()},
            new IStaticCodeBook[] {new MCN1.Page6_0(), new MCN1.Page6_1()},
            new IStaticCodeBook[] {new MCN1.Page7_0(), new MCN1.Page7_1()},
            new IStaticCodeBook[] {new MCN1.Page8_0(), new MCN1.Page8_1(), new CN1.Page8_2()}
        };
    }

    public class ManagedBlock0 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new MC0.Page1_0()},
            new IStaticCodeBook[] {null, null, new MC0.Page2_0()},
            new IStaticCodeBook[] {null, null, new MC0.Page3_0()},
            new IStaticCodeBook[] {null, null, new MC0.Page4_0()},
            new IStaticCodeBook[] {null, null, new MC0.Page5_0()},
            new IStaticCodeBook[] {new MC0.Page6_0(), new MC0.Page6_1()},
            new IStaticCodeBook[] {new MC0.Page7_0(), new MC0.Page7_1()},
            new IStaticCodeBook[] {new MC0.Page8_0(), new MC0.Page8_1(), new C0.Page8_2()}
        };
    }

    public class ManagedBlock1 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new MC1.Page1_0()},
            new IStaticCodeBook[] {null, null, new MC1.Page2_0()},
            new IStaticCodeBook[] {null, null, new MC1.Page3_0()},
            new IStaticCodeBook[] {null, null, new MC1.Page4_0()},
            new IStaticCodeBook[] {null, null, new MC1.Page5_0()},
            new IStaticCodeBook[] {new MC1.Page6_0(), new MC1.Page6_1()},
            new IStaticCodeBook[] {new MC1.Page7_0(), new MC1.Page7_1()},
            new IStaticCodeBook[] {new MC1.Page8_0(), new MC1.Page8_1(), new C1.Page8_2()}
        };
    }
}
