namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapter0;

public class ManagedChapter0Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         5, 4, 9,10, 9,10,11,12,13, 4, 1, 5, 7, 7, 9,11,
        12,14, 8, 5, 7, 9, 8,10,13,13,13,10, 7, 9, 4, 6,
         7,10,12,14, 9, 6, 7, 6, 6, 7,10,12,12, 9, 8, 9,
         7, 6, 7, 8,11,12,11,11,11, 9, 8, 7, 8,10,12,12,
        13,14,12,11, 9, 9, 9,12,12,17,17,15,16,12,10,11,
        13,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
