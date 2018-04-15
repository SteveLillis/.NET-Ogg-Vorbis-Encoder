namespace OggVorbisEncoder.Setup.Templates.Mono11.BookBlocks.Chapter0
{
    public class Block0 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new Page1()},
            new IStaticCodeBook[] {null, null, new Page2()},
            new IStaticCodeBook[] {null, null, new Page3()},
            new IStaticCodeBook[] {null, null, new Page4()},
            new IStaticCodeBook[] {null, null, new Page5()},
            new IStaticCodeBook[] {new Page6_0(), new Page6_1()},
            new IStaticCodeBook[] {new Page7_0(), new Page7_1(), new Page7_2()},
        };
    }
}