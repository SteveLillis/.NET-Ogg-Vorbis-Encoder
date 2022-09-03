namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter9;

public class Page3_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 4, 4, 5, 5, 7, 7, 8, 8, 4, 5, 5, 6, 6, 7, 7,
         9, 9, 4, 4, 5, 6, 6, 7, 7, 9, 9, 5, 6, 6, 7, 7,
         8, 8, 9, 9, 5, 6, 6, 7, 7, 8, 8, 9, 9, 7, 7, 7,
         8, 8, 9, 9,10,10, 7, 7, 7, 8, 8, 9, 9,10,10, 8,
         9, 9,10, 9,10,10,11,11, 8, 9, 9, 9,10,10,10,11,
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
