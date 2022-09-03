namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapterNeg1;

public class ManagedChapterNeg1Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         5, 6,12,14,12,14,16,17,18, 4, 2, 5,11, 7,10,12,
        14,15, 9, 4, 5,11, 7,10,13,15,18,15, 6, 7, 5, 6,
         8,11,13,16,11, 5, 6, 5, 5, 6, 9,13,15,12, 5, 7,
         6, 5, 6, 9,12,14,12, 6, 7, 8, 6, 7, 9,12,13,14,
         8, 8, 7, 5, 5, 8,10,12,16, 9, 9, 8, 6, 6, 7, 9,
         9,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
