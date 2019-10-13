namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter6
{
    public class Page8_0 : IStaticCodeBook
    {
        public int Dimensions { get; } = 2;

        public byte[] LengthList { get; } = {
         1, 4, 4, 6, 6, 8, 8, 9, 9,10,10, 4, 6, 6, 7, 7,
         9, 9,10,10,11,11, 4, 6, 6, 7, 7, 9, 9,10,10,11,
        11, 6, 8, 8, 9, 9,10,10,11,11,12,12, 6, 8, 8, 9,
         9,10,10,11,11,12,12, 8, 9, 9,10,10,11,11,12,12,
        13,13, 8, 9, 9,10,10,11,11,12,12,13,13,10,10,10,
        11,11,13,13,13,13,15,14, 9,10,10,12,11,12,13,13,
        13,14,15,11,12,12,13,13,13,13,15,14,15,15,11,11,
        12,13,13,14,14,14,15,15,15,
};

        public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
        public int QuantMin { get; } = -524582912;
        public int QuantDelta { get; } = 1618345984;
        public int Quant { get; } = 4;
        public int QuantSequenceP { get; } = 0;

        public int[] QuantList { get; } = {
        5,
        4,
        6,
        3,
        7,
        2,
        8,
        1,
        9,
        0,
        10,
};
    }
}