namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo8.Coupled.Chapter1;

public class Page5_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 3, 3, 4, 5, 6, 6, 8, 8, 0, 0, 0, 8, 8, 7, 7,
         9, 9, 0, 0, 0, 8, 8, 7, 7, 9, 9, 0, 0, 0, 9,10,
         8, 8, 9, 9, 0, 0, 0,10,10, 8, 8, 9, 9, 0, 0, 0,
        11,10, 8, 8,10,10, 0, 0, 0,11,11, 8, 8,10,10, 0,
         0, 0,12,12, 9, 9,10,10, 0, 0, 0, 0, 0, 9, 9,10,
        10,
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
