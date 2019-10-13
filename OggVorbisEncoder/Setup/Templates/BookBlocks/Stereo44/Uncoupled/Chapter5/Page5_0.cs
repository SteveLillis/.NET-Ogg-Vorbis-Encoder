namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter5
{
    public class Page5_0 : IStaticCodeBook
    {
        public int Dimensions { get; } = 2;

        public byte[] LengthList { get; } = {
         2, 3, 3, 6, 6, 8, 8,10,10, 4, 5, 5, 8, 7, 8, 8,
        11,10, 3, 5, 5, 7, 8, 8, 8,10,11, 6, 8, 7,10, 9,
        10,10,11,11, 6, 7, 8, 9, 9, 9,10,11,12, 8, 8, 8,
        10,10,11,11,13,12, 8, 8, 9, 9,10,11,11,12,13,10,
        11,10,12,11,13,12,14,14,10,10,11,11,12,12,13,14,
        14,
};

        public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
        public int QuantMin { get; } = -531628032;
        public int QuantDelta { get; } = 1611661312;
        public int Quant { get; } = 4;
        public int QuantSequenceP { get; } = 0;

        public int[] QuantList { get; } = {
        4,
        3,
        5,
        2,
        6,
        1,
        7,
        0,
        8,
};
    }
}