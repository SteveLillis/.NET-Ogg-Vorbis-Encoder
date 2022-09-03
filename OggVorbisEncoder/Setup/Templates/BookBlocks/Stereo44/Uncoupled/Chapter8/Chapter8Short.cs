namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter8;

public class Chapter8Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         6,14,18,18,17,17,17,17,17,17, 4, 7, 9, 9,10,13,
        15,17,17,17, 6, 7, 5, 6, 8,11,16,17,16,17, 5, 7,
         5, 4, 6,10,14,17,17,17, 6, 6, 6, 5, 7,10,13,16,
        17,17, 7, 6, 7, 7, 7, 8, 7,10,15,16,12, 9, 9, 6,
         6, 5, 3, 5,11,15,14,14,13, 5, 5, 7, 3, 4, 8,15,
        17,17,13, 7, 7,10, 6, 6,10,15,17,17,16,10,11,14,
        10,10,15,17,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
