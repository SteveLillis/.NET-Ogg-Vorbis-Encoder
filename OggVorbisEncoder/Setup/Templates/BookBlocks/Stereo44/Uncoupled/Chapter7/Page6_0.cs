namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter7;

public class Page6_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 4, 4, 5, 5, 7, 7, 9, 9, 4, 5, 4, 6, 6, 8, 7,
         9, 9, 4, 4, 5, 6, 6, 7, 7, 9, 9, 5, 6, 6, 7, 7,
         8, 8,10,10, 5, 6, 6, 7, 7, 8, 8,10,10, 7, 8, 7,
         8, 8,10, 9,11,11, 7, 7, 8, 8, 8, 9,10,11,11, 9,
         9, 9,10,10,11,10,12,11, 9, 9, 9,10,10,11,11,11,
        12,
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
