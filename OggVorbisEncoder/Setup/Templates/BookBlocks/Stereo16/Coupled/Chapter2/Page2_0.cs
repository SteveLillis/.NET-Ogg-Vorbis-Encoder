namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Coupled.Chapter2
{
    public class Page2_0 : IStaticCodeBook
    {
        public int Dimensions { get; } = 4;

        public byte[] LengthList { get; } = {
	 2, 4, 4, 7, 7, 0, 0, 0, 8, 8, 0, 0, 0, 8, 8, 0,
	 0, 0, 8, 8, 0, 0, 0, 8, 8, 4, 4, 4, 8, 7, 0, 0,
	 0, 8, 8, 0, 0, 0, 8, 8, 0, 0, 0, 9, 9, 0, 0, 0,
	 9, 9, 4, 4, 4, 7, 8, 0, 0, 0, 8, 8, 0, 0, 0, 8,
	 8, 0, 0, 0, 9, 9, 0, 0, 0, 9, 9, 7, 8, 8,10, 9,
	 0, 0, 0,12,11, 0, 0, 0,11,12, 0, 0, 0,14,13, 0,
	 0, 0,14,14, 7, 8, 8, 9,10, 0, 0, 0,11,12, 0, 0,
	 0,11,11, 0, 0, 0,14,14, 0, 0, 0,14,14, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 8, 8, 8,11,11, 0, 0, 0,
	12,11, 0, 0, 0,12,12, 0, 0, 0,13,12, 0, 0, 0,13,
	13, 8, 8, 8,11,11, 0, 0, 0,11,11, 0, 0, 0,12,12,
	 0, 0, 0,13,13, 0, 0, 0,13,13, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 8, 9, 8,12,11, 0, 0, 0,12,12, 0,
	 0, 0,12,11, 0, 0, 0,13,13, 0, 0, 0,13,13, 8, 8,
	 8,11,12, 0, 0, 0,11,12, 0, 0, 0,11,12, 0, 0, 0,
	13,14, 0, 0, 0,13,13, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 8, 9, 9,14,14, 0, 0, 0,13,13, 0, 0, 0,13,
	13, 0, 0, 0,13,12, 0, 0, 0,13,13, 8, 9, 9,14,14,
	 0, 0, 0,13,13, 0, 0, 0,13,13, 0, 0, 0,12,13, 0,
	 0, 0,13,13, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
	 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8,
	 9, 9,14,14, 0, 0, 0,13,13, 0, 0, 0,13,13, 0, 0,
	 0,13,13, 0, 0, 0,13,12, 8, 9, 9,14,14, 0, 0, 0,
	13,13, 0, 0, 0,13,13, 0, 0, 0,13,13, 0, 0, 0,12,
	12,
};

        public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
        public int QuantMin { get; } = -533725184;
        public int QuantDelta { get; } = 1611661312;
        public int Quant { get; } = 3;
        public int QuantSequenceP { get; } = 0;

        public int[] QuantList { get; } = {
	2,
	1,
	3,
	0,
	4,
};
    }
}