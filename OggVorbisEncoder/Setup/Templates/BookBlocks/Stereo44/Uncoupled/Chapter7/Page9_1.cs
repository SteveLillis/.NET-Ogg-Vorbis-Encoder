namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter7;

public class Page9_1 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 6, 5, 8, 6, 9, 8,10, 9,11,10, 4, 6, 6,
         8, 8, 9, 9,11,10,11,11,11,11, 4, 6, 6, 8, 8,10,
         9,11,11,11,11,11,12, 6, 8, 8,10,10,11,11,12,12,
        13,12,13,13, 6, 8, 8,10,10,11,11,12,12,12,13,14,
        13, 8,10,10,11,11,12,13,14,14,14,14,15,15, 8,10,
        10,11,12,12,13,13,14,14,14,14,15, 9,11,11,13,13,
        14,14,15,14,16,15,17,15, 9,11,11,12,13,14,14,15,
        14,15,15,15,16,10,12,12,13,14,15,15,15,15,16,17,
        16,17,10,13,12,13,14,14,16,16,16,16,15,16,17,11,
        13,13,14,15,14,17,15,16,17,17,17,17,11,13,13,14,
        15,15,15,15,17,17,16,17,16,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -518889472;
    public int QuantDelta { get; } = 1622704128;
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
