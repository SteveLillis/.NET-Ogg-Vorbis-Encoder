namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapter1
{
    public class Page5_0 : IStaticCodeBook
    {
        public int Dimensions { get; } = 2;

        public byte[] LengthList { get; } = {
         2, 3, 3, 6, 6, 7, 7, 8, 8, 8, 8, 9, 9,10,10,11,
        11, 0, 5, 5, 6, 6, 8, 8, 9, 9, 9, 9,10,10,10,10,
        11,11, 0, 5, 5, 6, 6, 8, 8, 9, 9, 9, 9,10,10,10,
        10,11,11, 0, 7, 7, 7, 7, 8, 8, 9, 9, 9, 9,10,10,
        11,11,12,12, 0, 0, 0, 7, 7, 8, 8, 9, 9, 9, 9,10,
        10,11,11,12,12, 0, 0, 0, 8, 8, 8, 8, 9, 9,10,10,
        10,11,11,11,12,12, 0, 0, 0, 8, 8, 8, 8, 9, 9,10,
        10,10,10,11,11,12,12, 0, 0, 0, 9, 9, 9, 9,10,10,
        10,10,11,11,12,12,12,12, 0, 0, 0, 0, 0, 9, 9,10,
        10,10,10,11,11,12,12,13,13, 0, 0, 0, 0, 0, 9, 9,
         9, 9,10,10,11,11,12,12,13,13, 0, 0, 0, 0, 0, 9,
         9, 9, 9,10,10,11,11,12,12,13,13, 0, 0, 0, 0, 0,
         9, 9,10,10,11,11,12,12,12,12,13,13, 0, 0, 0, 0,
         0, 0, 0,10,10,11,11,12,12,12,12,13,13, 0, 0, 0,
         0, 0, 0, 0,11,11,11,11,12,12,13,13,13,13, 0, 0,
         0, 0, 0, 0, 0,11,11,11,11,12,12,13,13,13,13, 0,
         0, 0, 0, 0, 0, 0,11,11,12,12,12,12,13,13,14,14,
         0, 0, 0, 0, 0, 0, 0, 0, 0,12,12,12,12,13,13,14,
        14,
};

        public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
        public int QuantMin { get; } = -529530880;
        public int QuantDelta { get; } = 1611661312;
        public int Quant { get; } = 5;
        public int QuantSequenceP { get; } = 0;

        public int[] QuantList { get; } = {
        8,
        7,
        9,
        6,
        10,
        5,
        11,
        4,
        12,
        3,
        13,
        2,
        14,
        1,
        15,
        0,
        16,
};
    }
}