namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter2;

public class Page9_1 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 6, 6, 7, 6, 8, 8,10, 9,10,10, 6, 5, 5,
         7, 7, 8, 7,10, 9,11,11,12,13, 6, 5, 5, 7, 7, 8,
         8,10,10,11,11,13,13,18, 8, 8, 8, 8, 9, 9,10,10,
        12,12,12,13,18, 8, 8, 8, 8, 9, 9,10,10,12,12,13,
        13,18,11,11, 8, 8,10,10,11,11,12,11,13,12,18,11,
        11, 9, 7,10,10,11,11,11,12,12,13,17,17,17,10,10,
        11,11,12,12,12,10,12,12,17,17,17,11,10,11,10,13,
        12,11,12,12,12,17,17,17,15,14,11,11,12,11,13,10,
        13,12,17,17,17,14,14,12,10,11,11,13,13,13,13,17,
        17,16,17,16,13,13,12,10,13,10,14,13,17,16,17,16,
        17,13,12,12,10,13,11,14,14,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -522616832;
    public int QuantDelta { get; } = 1620115456;
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
