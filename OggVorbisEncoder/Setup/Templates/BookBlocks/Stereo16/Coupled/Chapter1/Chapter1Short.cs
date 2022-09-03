namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Coupled.Chapter1;

public class Chapter1Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         5, 6,17, 8,12, 9,10,10,12,13, 5, 2,17, 4, 9, 5,
         7, 8,11,13,16,16,16,16,16,16,16,16,16,16, 6, 4,
        16, 5,10, 5, 7,10,14,16,13, 9,16,11, 8, 7, 8, 9,
        13,16, 7, 4,16, 5, 7, 4, 6, 8,11,13, 8, 6,16, 7,
         8, 5, 5, 7, 9,13, 9, 8,16, 9, 8, 6, 6, 7, 9,13,
        11,11,16,10,10, 7, 7, 7, 9,13,13,13,16,13,13, 9,
         9, 9,10,13,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
