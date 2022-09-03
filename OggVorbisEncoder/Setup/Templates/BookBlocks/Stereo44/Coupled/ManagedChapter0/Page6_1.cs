namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapter0;

public class Page6_1 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         2, 4, 4, 6, 6, 7, 7, 7, 7, 7, 8, 9, 5, 5, 6, 6,
         7, 7, 8, 8, 8, 8, 9, 5, 5, 6, 6, 7, 7, 8, 8, 8,
         8,10, 7, 7, 7, 7, 7, 7, 8, 8, 8, 8,10,10,10, 7,
         7, 7, 7, 8, 8, 8, 8,10,10,10, 8, 8, 8, 8, 8, 8,
         8, 8,10,10,10, 8, 8, 8, 8, 8, 8, 8, 8,10,10,10,
         8, 8, 8, 8, 8, 8, 8, 8,10,10,10,10,10, 8, 8, 8,
         8, 8, 8,10,10,10,10,10, 9, 9, 8, 8, 8, 8,10,10,
        10,10,10, 8, 8, 8, 8, 8, 8,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -531365888;
    public int QuantDelta { get; } = 1611661312;
    public int Quant { get; } = 4;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = {
        5,
        4,
        6,
        3,
        7,
        2,
        8,
        1,
        9,
        0,
        10,
    };
}
