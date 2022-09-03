namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter6;

public class Page6_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 6, 6, 8, 8, 8, 8,10, 9,10,10, 6, 5, 5,
         7, 7, 9, 9, 9, 9,10,10,11,11, 6, 5, 5, 7, 7, 9,
         9,10, 9,11,10,11,11, 0, 6, 6, 7, 7, 9, 9,10,10,
        11,11,12,12, 0, 7, 7, 7, 7, 9, 9,10,10,11,11,12,
        12, 0,11,11, 8, 8,10,10,11,11,12,12,12,12, 0,11,
        12, 9, 8,10,10,11,11,12,12,13,13, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
         0, 0, 0, 0, 0, 0, 0, 0, 0,
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
