namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapter1;

public class ManagedChapter1Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         5, 4, 8,10, 9, 9,10,11,12, 4, 2, 5, 6, 6, 8,10,
        11,13, 8, 4, 6, 8, 7, 9,12,12,14,10, 6, 8, 4, 5,
         6, 9,11,12, 9, 5, 6, 5, 5, 6, 9,11,11, 9, 7, 9,
         6, 5, 5, 7,10,10,10, 9,11, 8, 7, 6, 7, 9,11,11,
        12,13,10,10, 9, 8, 9,11,11,15,15,12,13,11, 9,10,
        11,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
