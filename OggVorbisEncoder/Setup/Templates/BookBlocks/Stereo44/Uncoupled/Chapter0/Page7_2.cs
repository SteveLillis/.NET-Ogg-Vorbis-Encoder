namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter0;

public class Page7_2 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         2, 5, 4, 6, 6, 7, 7, 8, 8, 8, 8, 9, 8, 5, 5, 6,
         7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 5, 6, 5, 7, 7, 8,
         8, 8, 8, 9, 9, 9, 9, 6, 7, 7, 8, 8, 8, 8, 9, 8,
         9, 9, 9, 9, 6, 7, 7, 8, 7, 8, 8, 9, 9, 9, 9, 9,
         9, 7, 8, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9, 9, 7, 8,
         8, 9, 8, 9, 8, 9, 9, 9, 9, 9, 9, 8, 9, 8, 9, 9,
         9, 9, 9, 9, 9, 9,10,10, 8, 8, 9, 9, 9, 9, 9, 9,
         9, 9,10, 9,10, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9,
         9, 9, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9,
         9, 9, 9, 9, 9, 9, 9, 9,10,10,10, 9, 9, 9, 9, 9,
         9, 9, 9,10, 9, 9,10,10, 9,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -531103744;
    public int QuantDelta { get; } = 1611661312;
    public int Quant { get; } = 4;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = {
        6,
        5,
        7,
        4,
        8,
        3,
        9,
        2,
        10,
        1,
        11,
        0,
        12,
    };
}
