﻿using C0 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Coupled.Chapter0;
using C1 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Coupled.Chapter1;
using C2 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Coupled.Chapter2;

namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Coupled
{
    class Blocks
    {
        public class Block0 : IStaticBookBlock
        {
            public IStaticCodeBook[][] Books { get; } = {
                new IStaticCodeBook[] {null},
                new IStaticCodeBook[] {null, null, new C0.Page1_0()},
                new IStaticCodeBook[] {null},
                new IStaticCodeBook[] {null, null, new C0.Page3_0()},
                new IStaticCodeBook[] {null, null, new C0.Page4_0()},
                new IStaticCodeBook[] {null, null, new C0.Page5_0()},
                new IStaticCodeBook[] {null, null, new C0.Page6_0()},
                new IStaticCodeBook[] {new C0.Page7_0(), new C0.Page7_1()},
                new IStaticCodeBook[] {new C0.Page8_0(), new C0.Page8_1()},
                new IStaticCodeBook[] {new C0.Page9_0(), new C0.Page9_1(), new C0.Page9_2()}
            };
        }

        public class Block1 : IStaticBookBlock
        {
            public IStaticCodeBook[][] Books { get; } = {
                new IStaticCodeBook[] {null},
                new IStaticCodeBook[] {null, null, new C1.Page1_0()},
                new IStaticCodeBook[] {null},
                new IStaticCodeBook[] {null, null, new C1.Page3_0()},
                new IStaticCodeBook[] {null, null, new C1.Page4_0()},
                new IStaticCodeBook[] {null, null, new C1.Page5_0()},
                new IStaticCodeBook[] {null, null, new C1.Page6_0()},
                new IStaticCodeBook[] {new C1.Page7_0(), new C1.Page7_1()},
                new IStaticCodeBook[] {new C1.Page8_0(), new C1.Page8_1()},
                new IStaticCodeBook[] {new C1.Page9_0(), new C1.Page9_1(), new C1.Page9_2()}
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
                new IStaticCodeBook[] {new C2.Page5_0(), new C2.Page5_1()},
                new IStaticCodeBook[] {new C2.Page6_0(), new C2.Page6_1()},
                new IStaticCodeBook[] {new C2.Page7_0(), new C2.Page7_1()},
                new IStaticCodeBook[] {new C2.Page8_0(), new C2.Page8_1()},
                new IStaticCodeBook[] {new C2.Page9_0(), new C2.Page9_1(), new C2.Page9_2()}
            };
        }
    }
}
