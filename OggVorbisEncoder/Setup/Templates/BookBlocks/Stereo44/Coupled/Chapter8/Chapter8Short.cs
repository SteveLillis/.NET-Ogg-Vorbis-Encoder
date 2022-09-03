namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter8;

public class Chapter8Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         4,11,13,14,15,15,18,17,19,17, 5, 6, 8, 9,10,10,
        12,15,19,19, 6, 6, 6, 6, 8, 8,11,14,18,19, 8, 6,
         5, 4, 6, 7,10,13,16,17, 9, 7, 6, 5, 6, 7, 9,12,
        15,19,10, 8, 7, 6, 6, 6, 7, 9,13,15,12,10, 9, 8,
         7, 6, 4, 5,10,15,13,13,11, 8, 6, 6, 4, 2, 7,12,
        17,15,16,10, 8, 8, 7, 6, 9,12,19,18,17,13,11,10,
        10, 9,11,14,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
