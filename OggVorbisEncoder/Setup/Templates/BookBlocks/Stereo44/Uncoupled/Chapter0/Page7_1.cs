namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter0;

public class Page7_1 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 6, 6, 6, 6, 7, 7, 8, 8, 9, 9, 5, 7, 7,
         8, 7, 7, 7, 9, 8,10, 9,10,11, 5, 7, 7, 8, 8, 7,
         7, 8, 9,10,10,11,11, 6, 8, 8, 9, 9, 9, 9,11,10,
        12,12,15,12, 6, 8, 8, 9, 9, 9, 9,11,11,12,11,14,
        12, 7, 8, 8,10,10,12,12,13,13,13,15,13,13, 7, 8,
         8,10,10,11,11,13,12,14,15,15,15, 9,10,10,11,12,
        13,13,14,15,14,15,14,15, 8,10,10,12,12,14,14,15,
        14,14,15,15,14,10,12,12,14,14,15,14,15,15,15,14,
        15,15,10,12,12,13,14,15,14,15,15,14,15,15,15,12,
        15,13,15,14,15,15,15,15,15,15,15,15,13,13,15,15,
        15,15,15,15,15,15,15,15,15,
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
