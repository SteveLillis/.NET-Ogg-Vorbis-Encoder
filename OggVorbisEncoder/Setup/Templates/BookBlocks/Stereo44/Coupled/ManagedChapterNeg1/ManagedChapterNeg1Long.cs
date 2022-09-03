namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapterNeg1;

public class ManagedChapterNeg1Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 3, 8, 8, 8, 8,10,12,14, 3, 2, 6, 7, 7, 8,10,
        12,16, 7, 6, 7, 9, 8,10,12,14,16, 8, 6, 8, 4, 5,
         7, 9,11,13, 7, 6, 8, 5, 6, 7, 9,11,14, 8, 8,10,
         7, 7, 6, 8,10,13, 9,11,12, 9, 9, 7, 8,10,12,10,
        13,15,11,11,10, 9,10,13,13,16,17,14,15,14,13,14,
        17,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
