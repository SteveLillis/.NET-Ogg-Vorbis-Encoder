namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.ChapterNeg1;

public class Page6_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 6, 6, 8, 8,10,10,11,11,15,15, 4, 5, 5,
         8, 8, 9, 9,11,11,12,12,16,16, 4, 5, 6, 8, 8, 9,
         9,11,11,12,12,14,14, 7, 8, 8, 9, 9,10,10,11,12,
        13,13,16,17, 7, 8, 8, 9, 9,10,10,12,12,12,13,15,
        15, 9,10,10,10,10,11,11,12,12,13,13,15,16, 9, 9,
         9,10,10,11,11,13,12,13,13,17,17,10,11,11,11,12,
        12,12,13,13,14,15, 0,18,10,11,11,12,12,12,13,14,
        13,14,14,17,16,11,12,12,13,13,14,14,14,14,15,16,
        17,16,11,12,12,13,13,14,14,14,14,15,15,17,17,14,
        15,15,16,16,16,17,17,16, 0,17, 0,18,14,15,15,16,
        16, 0,15,18,18, 0,16, 0, 0,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -526516224;
    public int QuantDelta { get; } = 1616117760;
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
