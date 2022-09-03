namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Coupled.Chapter0;

public class Page8_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 7, 7, 7, 7, 7, 6, 8, 8,10,10, 6, 5, 6,
         8, 8, 8, 8, 8, 8, 8, 9,10,10, 7, 6, 6, 8, 8, 8,
         8, 8, 8, 8, 8,10,10, 0, 8, 8, 8, 8, 9, 8, 9, 9,
         9,10,10,10, 0, 9, 8, 8, 8, 9, 9, 8, 8, 9, 9,10,
        10, 0,12,11, 8, 8, 9, 9, 9, 9,10,10,11,10, 0,12,
        13, 8, 8, 9,10, 9, 9,11,11,11,12, 0, 0, 0, 8, 8,
         8, 8,10, 9,12,13,12,14, 0, 0, 0, 8, 8, 8, 9,10,
        10,12,12,13,14, 0, 0, 0,13,13, 9, 9,11,11, 0, 0,
        14, 0, 0, 0, 0,14,14,10,10,12,11,12,14,14,14, 0,
         0, 0, 0, 0,11,11,13,13,14,13,14,14, 0, 0, 0, 0,
         0,12,13,13,12,13,14,14,14,
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
