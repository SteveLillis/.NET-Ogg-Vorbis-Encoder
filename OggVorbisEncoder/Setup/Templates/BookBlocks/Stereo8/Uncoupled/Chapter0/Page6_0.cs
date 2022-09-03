namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo8.Uncoupled.Chapter0;

public class Page6_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 7, 7, 9, 9,11,11,12,12,16,16, 3, 6, 6,
         9, 9,11,11,12,12,13,14,18,16, 3, 6, 7, 9, 9,11,
        11,13,12,14,14,17,16, 7, 9, 9,11,11,12,12,14,14,
        14,14,17,16, 7, 9, 9,11,11,13,12,13,13,14,14,17,
         0, 9,11,11,12,13,14,14,14,13,15,14,17,17, 9,11,
        11,12,12,14,14,13,14,14,15, 0, 0,11,12,12,15,14,
        15,14,15,14,15,16,17, 0,11,12,13,13,13,14,14,15,
        14,15,15, 0, 0,12,14,14,15,15,14,16,15,15,17,16,
         0,18,13,14,14,15,14,15,14,15,16,17,16, 0, 0,17,
        17,18, 0,16,18,16, 0, 0, 0,17, 0, 0,16, 0, 0,16,
        16, 0,15, 0,17, 0, 0, 0, 0,
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
