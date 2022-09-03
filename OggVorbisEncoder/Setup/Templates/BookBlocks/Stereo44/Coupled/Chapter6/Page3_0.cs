namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter6;

public class Page3_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         2, 3, 4, 6, 6, 7, 7, 9, 9, 0, 4, 4, 6, 6, 7, 7,
         9,10, 0, 4, 4, 6, 6, 7, 7,10, 9, 0, 5, 5, 7, 7,
         8, 8,10,10, 0, 0, 0, 7, 6, 8, 8,10,10, 0, 0, 0,
         7, 7, 9, 9,11,11, 0, 0, 0, 7, 7, 9, 9,11,11, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0,
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
