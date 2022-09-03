namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter2;

public class Page7_1 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 7, 6, 7, 6, 8, 7, 9, 7, 9, 8, 4, 7, 6,
         8, 8, 9, 8,10, 9,10,10,11,11, 4, 7, 7, 8, 8, 8,
         8, 9,10,11,11,11,11, 6, 8, 8,10,10,10,10,11,11,
        12,12,12,12, 7, 8, 8,10,10,10,10,11,11,12,12,13,
        13, 7, 9, 9,11,10,12,12,13,13,14,13,14,14, 7, 9,
         9,10,11,11,12,13,13,13,13,16,14, 9,10,10,12,12,
        13,13,14,14,15,16,15,16, 9,10,10,12,12,12,13,14,
        14,14,15,16,15,10,12,12,13,13,15,13,16,16,15,17,
        17,17,10,11,11,12,14,14,14,15,15,17,17,15,17,11,
        12,12,14,14,14,15,15,15,17,16,17,17,10,12,12,13,
        14,14,14,17,15,17,17,17,17,
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
