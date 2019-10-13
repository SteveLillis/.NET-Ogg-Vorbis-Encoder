namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter4
{
    public class Page6_0 : IStaticCodeBook
    {
        public int Dimensions { get; } = 2;

        public byte[] LengthList { get; } = {
         1, 4, 4, 6, 6, 8, 8, 9, 9,11,10,13,13, 4, 6, 5,
         8, 8, 9, 9,10,10,11,11,14,14, 4, 6, 6, 8, 8, 9,
         9,10,10,11,11,14,14, 6, 8, 8, 9, 9,10,10,11,11,
        12,12,15,15, 6, 8, 8, 9, 9,10,11,11,11,12,12,15,
        15, 8, 9, 9,11,10,11,11,12,12,13,13,16,16, 8, 9,
         9,10,10,11,11,12,12,13,13,16,16,10,10,10,12,11,
        12,12,13,13,14,14,16,16,10,10,10,11,12,12,12,13,
        13,13,14,16,17,11,12,11,12,12,13,13,14,14,15,14,
        18,17,11,11,12,12,12,13,13,14,14,14,15,19,18,14,
        15,14,15,15,17,16,17,17,17,17,21, 0,14,15,15,16,
        16,16,16,17,17,18,17,20,21,
};

        public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
        public int QuantMin { get; } = -526516224;
        public int QuantDelta { get; } = 1616117760;
        public int Quant { get; } = 4;
        public int QuantSequenceP { get; } = 0;

        public int[] QuantList { get; } = {
        6,
        5,
        7,
        4,
        8,
        3,
        9,
        2,
        10,
        1,
        11,
        0,
        12,
};
    }
}