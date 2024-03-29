namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter1;

public class Page9_1 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 6, 5, 9, 9,10,10, 6, 7, 9, 9,10,10,10,10, 5,
        10, 8,10, 8,10,10, 8, 8,10, 9,10,10,10,10, 5, 8,
         9,10,10,10,10, 8,10,10,10,10,10,10,10, 9,10,10,
        10,10,10,10, 9, 9,10,10,10,10,10,10, 9, 9, 8, 9,
        10,10,10, 9,10,10,10,10,10,10,10,10,10,10,10,10,
        10,10,10,10,10,10,10,10,10,10,10, 8,10,10,10,10,
        10,10,10,10,10,10,10,10,10, 6, 8, 8,10,10,10, 8,
        10,10,10,10,10,10,10,10, 5, 8, 8,10,10,10, 9, 9,
        10,10,10,10,10,10,10,10, 9,10,10,10,10,10,10,10,
        10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,
        10,10,10,10,10,10,10,10, 9, 9, 9, 9, 9, 9, 9, 9,
         9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9,
         9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9,
         9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9,
         9,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -522338304;
    public int QuantDelta { get; } = 1620115456;
    public int Quant { get; } = 4;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = {
        7,
        6,
        8,
        5,
        9,
        4,
        10,
        3,
        11,
        2,
        12,
        1,
        13,
        0,
        14,
    };
}
