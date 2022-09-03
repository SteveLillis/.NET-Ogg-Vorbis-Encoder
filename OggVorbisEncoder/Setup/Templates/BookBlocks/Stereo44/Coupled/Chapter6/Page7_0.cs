namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter6;

public class Page7_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 6, 6, 8, 8, 8, 8,10,10,11,10, 6, 5, 5,
         7, 7, 8, 8, 9, 9,10,10,12,11, 6, 5, 5, 7, 7, 8,
         8, 9, 9,10,10,12,11,21, 7, 7, 7, 7, 9, 9,10,10,
        11,11,12,12,21, 7, 7, 7, 7, 9, 9,10,10,11,11,12,
        12,21,12,12, 9, 9,10,10,11,11,11,11,12,12,21,12,
        12, 9, 9,10,10,11,11,12,12,12,12,21,21,21,11,11,
        10,10,11,12,12,12,13,13,21,21,21,11,11,10,10,12,
        12,12,12,13,13,21,21,21,15,15,11,11,12,12,13,13,
        13,13,21,21,21,15,16,11,11,12,12,13,13,14,14,21,
        21,21,21,20,13,13,13,13,13,13,14,14,20,20,20,20,
        20,13,13,13,13,13,13,14,14,
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
