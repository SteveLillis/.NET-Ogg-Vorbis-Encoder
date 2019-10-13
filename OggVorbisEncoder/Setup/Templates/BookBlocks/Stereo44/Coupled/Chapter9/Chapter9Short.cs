namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter9
{
    public class Chapter9Short : IStaticCodeBook
    {
        public int Dimensions { get; } = 2;

        public byte[] LengthList { get; } = {
         5,13,18,16,17,17,19,18,19,19, 5, 7,10,11,12,12,
        13,16,17,18, 6, 6, 7, 7, 9, 9,10,14,17,19, 8, 7,
         6, 5, 6, 7, 9,12,19,17, 8, 7, 7, 6, 5, 6, 8,11,
        15,19, 9, 8, 7, 6, 5, 5, 6, 8,13,15,11,10, 8, 8,
         7, 5, 4, 4,10,14,12,13,11, 9, 7, 6, 4, 2, 6,12,
        18,16,16,13, 8, 7, 7, 5, 8,13,16,17,18,15,11, 9,
         9, 8,10,13,
};

        public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
        public int QuantMin { get; } = 0;
        public int QuantDelta { get; } = 0;
        public int Quant { get; } = 0;
        public int QuantSequenceP { get; } = 0;

        public int[] QuantList { get; } = null;
    }
}