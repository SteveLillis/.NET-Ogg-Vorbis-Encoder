namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter1
{
    public class Page2_0 : IStaticCodeBook
    {
        public int Dimensions { get; } = 4;

        public byte[] LengthList { get; } = {
         3, 4, 4, 5, 6, 6, 5, 6, 6, 5, 6, 6, 6, 7, 8, 6,
         7, 8, 5, 6, 6, 6, 8, 7, 6, 8, 7, 5, 6, 6, 6, 8,
         8, 6, 8, 8, 6, 8, 8, 7, 7,10, 8, 9, 9, 6, 8, 8,
         7, 9, 8, 8, 9,10, 5, 6, 6, 6, 8, 8, 7, 8, 8, 6,
         8, 8, 8,10, 9, 7, 8, 9, 6, 8, 8, 8, 9, 9, 7,10,
         8,
};

        public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
        public int QuantMin { get; } = -535822336;
        public int QuantDelta { get; } = 1611661312;
        public int Quant { get; } = 2;
        public int QuantSequenceP { get; } = 0;

        public int[] QuantList { get; } = {
        1,
        0,
        2,
};
    }
}