namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter6
{
    public class Page5_0 : IStaticCodeBook
    {
        public int Dimensions { get; } = 4;

        public byte[] LengthList { get; } = {
         1, 4, 4, 5, 7, 7, 6, 7, 7, 4, 6, 6, 9, 9,10,10,
        10, 9, 4, 6, 6, 9,10, 9,10, 9,10, 6, 9, 9,10,12,
        11,10,11,11, 7,10, 9,11,12,12,12,12,12, 7,10,10,
        11,12,12,12,12,12, 6,10,10,10,12,12,11,12,12, 7,
         9,10,11,12,12,12,12,12, 7,10, 9,12,12,12,12,12,
        12,
};

        public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
        public int QuantMin { get; } = -529137664;
        public int QuantDelta { get; } = 1618345984;
        public int Quant { get; } = 2;
        public int QuantSequenceP { get; } = 0;

        public int[] QuantList { get; } = {
        1,
        0,
        2,
};
    }
}