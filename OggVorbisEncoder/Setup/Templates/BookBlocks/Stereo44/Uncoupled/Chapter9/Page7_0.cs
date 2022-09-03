namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter9;

public class Page7_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 5, 6, 6, 7, 7, 8, 9,10,10,11,11, 5, 6, 6,
         7, 7, 8, 8, 9, 9,10,10,11,11, 5, 6, 6, 7, 7, 8,
         8, 9, 9,10,10,11,11, 6, 7, 7, 8, 8, 9, 9,10,10,
        11,11,12,12, 6, 7, 7, 8, 8, 9, 9,10,10,11,11,12,
        12, 8, 8, 8, 9, 9,10,10,11,11,12,12,13,13, 8, 8,
         8, 9, 9,10,10,11,11,12,12,13,13, 9, 9, 9,10,10,
        11,11,12,12,13,13,13,13, 9, 9, 9,10,10,11,11,12,
        12,13,13,14,14,10,10,10,11,11,12,12,13,13,14,13,
        15,14,10,10,10,11,11,12,12,13,13,14,14,14,14,11,
        11,12,12,12,13,13,14,14,14,14,15,15,11,11,12,12,
        12,13,13,14,14,14,15,15,15,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -523206656;
    public int QuantDelta { get; } = 1618345984;
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
