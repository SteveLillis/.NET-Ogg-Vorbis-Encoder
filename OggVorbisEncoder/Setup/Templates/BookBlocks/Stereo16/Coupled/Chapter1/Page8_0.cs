namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Coupled.Chapter1;

public class Page8_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 6, 6, 7, 7, 7, 7, 8, 8, 9, 9, 6, 5, 5,
         7, 8, 8, 9, 8, 8, 9, 9,10,11, 6, 5, 5, 8, 8, 9,
         9, 8, 8, 9,10,10,11, 0, 8, 8, 8, 9, 9, 9, 9, 9,
        10,10,11,11, 0, 9, 9, 9, 8, 9, 9, 9, 9,10,10,11,
        11, 0,13,13, 9, 9,10,10,10,10,11,11,12,12, 0,14,
        13, 9, 9,10,10,10,10,11,11,12,12, 0, 0, 0,10,10,
         9, 9,11,11,12,12,13,12, 0, 0, 0,10,10, 9, 9,10,
        10,12,12,13,13, 0, 0, 0,13,14,11,10,11,11,12,12,
        13,14, 0, 0, 0,14,14,10,10,11,11,12,12,13,13, 0,
         0, 0, 0, 0,12,12,12,12,13,13,14,15, 0, 0, 0, 0,
         0,12,12,12,12,13,13,14,15,
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
