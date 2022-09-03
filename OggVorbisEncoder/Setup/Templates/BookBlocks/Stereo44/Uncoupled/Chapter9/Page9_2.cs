namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter9;

public class Page9_2 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
         2, 4, 4, 5, 4, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6,
         6, 6, 6, 7, 6, 7, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7,
         7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
         7,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -526909440;
    public int QuantDelta { get; } = 1611661312;
    public int Quant { get; } = 6;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = {
        24,
        23,
        25,
        22,
        26,
        21,
        27,
        20,
        28,
        19,
        29,
        18,
        30,
        17,
        31,
        16,
        32,
        15,
        33,
        14,
        34,
        13,
        35,
        12,
        36,
        11,
        37,
        10,
        38,
        9,
        39,
        8,
        40,
        7,
        41,
        6,
        42,
        5,
        43,
        4,
        44,
        3,
        45,
        2,
        46,
        1,
        47,
        0,
        48,
    };
}
