namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.ChapterNeg1;

public class Page7_1 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 6, 6, 6, 6, 9, 8, 9, 8, 8, 8, 5, 7, 7,
         7, 7, 8, 8, 8,10, 8,10, 8, 9, 5, 7, 7, 8, 7, 7,
         8,10,10,11,10,12,11, 7, 8, 8, 9, 9, 9,10,11,11,
        11,11,11,11, 7, 8, 8, 8, 9, 9, 9,10,10,10,11,11,
        12, 7, 8, 8, 9, 9,10,11,11,12,11,12,11,11, 7, 8,
         8, 9, 9,10,10,11,11,11,12,12,11, 8,10,10,10,10,
        11,11,14,11,12,12,12,13, 9,10,10,10,10,12,11,14,
        11,14,11,12,13,10,11,11,11,11,13,11,14,14,13,13,
        13,14,11,11,11,12,11,12,12,12,13,14,14,13,14,12,
        11,12,12,12,12,13,13,13,14,13,14,14,11,12,12,14,
        12,13,13,12,13,13,14,14,14,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -523010048;
    public int QuantDelta { get; } = 1618608128;
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
