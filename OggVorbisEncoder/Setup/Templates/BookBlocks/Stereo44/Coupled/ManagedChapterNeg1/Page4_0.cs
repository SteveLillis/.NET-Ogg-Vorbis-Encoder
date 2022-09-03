namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapterNeg1;

public class Page4_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 3, 6, 6, 7, 7, 9, 9, 0, 5, 5, 7, 7, 8, 7,
         9, 9, 0, 5, 5, 7, 7, 8, 8, 9, 9, 0, 7, 7, 8, 8,
         8, 8,10,10, 0, 0, 0, 8, 8, 8, 8,10,10, 0, 0, 0,
         9, 9, 9, 9,10,10, 0, 0, 0, 9, 9, 9, 9,10,10, 0,
         0, 0,10,10,10,10,11,11, 0, 0, 0, 0, 0,10,10,11,
        11,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -531628032;
    public int QuantDelta { get; } = 1611661312;
    public int Quant { get; } = 4;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = {
        4,
        3,
        5,
        2,
        6,
        1,
        7,
        0,
        8,
    };
}
