namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo8.Coupled.Chapter1;

public class Page7_1 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         2, 3, 3, 5, 5, 7, 7, 7, 7, 7, 7,10,10, 9, 7, 7,
         7, 7, 8, 8, 8, 8, 9, 9, 9, 7, 7, 7, 7, 8, 8, 8,
         8,10,10,10, 7, 7, 7, 7, 8, 8, 8, 8,10,10,10, 7,
         7, 7, 7, 8, 8, 8, 8,10,10,10, 8, 8, 8, 8, 8, 8,
         8, 8,10,10,10, 8, 8, 8, 8, 8, 8, 8, 8,10,10,10,
         8, 8, 8, 8, 8, 8, 8, 8,10,10,10,10,10, 8, 8, 8,
         8, 8, 8,10,10,10,10,10, 8, 8, 8, 8, 8, 8,10,10,
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
