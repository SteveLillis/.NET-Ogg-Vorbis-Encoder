namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapter0;

public class ManagedChapter0Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         6, 6,12,13,13,14,16,17,17, 4, 2, 5, 8, 7, 9,12,
        15,15, 9, 4, 5, 9, 7, 9,12,16,18,11, 6, 7, 4, 6,
         8,11,14,18,10, 5, 6, 5, 5, 7,10,14,17,10, 5, 7,
         7, 6, 7,10,13,16,11, 5, 7, 7, 7, 8,10,12,15,13,
         6, 7, 5, 5, 7, 9,12,13,16, 8, 9, 6, 6, 7, 9,10,
        12,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
