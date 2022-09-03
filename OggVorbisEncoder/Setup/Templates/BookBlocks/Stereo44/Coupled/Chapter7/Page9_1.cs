namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter7;

public class Page9_1 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 7, 7, 7, 7, 7, 6, 8, 8, 8, 8, 6, 6, 6,
         8, 8, 9, 8, 8, 7, 9, 8,11,10, 5, 6, 6, 8, 8, 9,
         8, 8, 8,10, 9,11,11,16, 8, 8, 9, 8, 9, 9, 9, 8,
        10, 9,11,10,16, 8, 8, 9, 9,10,10, 9, 9,10,10,11,
        11,16,13,13, 9, 9,10,10, 9,10,11,11,12,11,16,13,
        13, 9, 8,10, 9,10,10,10,10,11,11,16,14,16, 8, 9,
         9, 9,11,10,11,11,12,11,16,16,16, 9, 7,10, 7,11,
        10,11,11,12,11,16,16,16,12,12, 9,10,11,11,12,11,
        12,12,16,16,16,12,10,10, 7,11, 8,12,11,12,12,16,
        16,15,16,16,11,12,10,10,12,11,12,12,16,16,16,15,
        15,11,11,10,10,12,12,12,12,
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
