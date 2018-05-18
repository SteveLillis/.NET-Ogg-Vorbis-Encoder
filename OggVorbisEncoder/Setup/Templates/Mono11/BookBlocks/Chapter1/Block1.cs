namespace OggVorbisEncoder.Setup.Templates.Mono11.BookBlocks.Chapter1
{
/*
static const static_bookblock _resbook_8u_1={
  {
    {0},
    {0,0,&_8u1__p1_0},
    {0,0,&_8u1__p2_0},
    {0,0,&_8u1__p3_0},
    {0,0,&_8u1__p4_0},
    {0,0,&_8u1__p5_0},
    {0,0,&_8u1__p6_0},
    {&_8u1__p7_0,&_8u1__p7_1},
    {&_8u1__p8_0,&_8u1__p8_1},
    {&_8u1__p9_0,&_8u1__p9_1,&_8u1__p9_2}
   }
}; 
*/
    public class Block1 : IStaticBookBlock
    {
        public IStaticCodeBook[][] Books { get; } = {
            new IStaticCodeBook[] {null},
            new IStaticCodeBook[] {null, null, new Page1()},
            new IStaticCodeBook[] {null, null, new Page2()},
            new IStaticCodeBook[] {null, null, new Page3()},
            new IStaticCodeBook[] {null, null, new Page4()},
            new IStaticCodeBook[] {null, null, new Page5()},
            new IStaticCodeBook[] {null, null, new Page6()},
            new IStaticCodeBook[] {new Page7_0(), new Page7_1()},
            new IStaticCodeBook[] {new Page8_0(), new Page8_1()},
            new IStaticCodeBook[] {new Page9_0(), new Page9_1(), new Page9_2()},
        };
    }
}