namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter0;

public class Page6_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 7, 7,10,10,12,12,13,13,18,17, 3, 6, 6,
         9, 9,11,11,13,13,14,14,18,17, 3, 6, 6, 9, 9,11,
        11,13,13,14,14,17,18, 7, 9, 9,11,11,13,13,14,14,
        15,15, 0, 0, 7, 9, 9,11,11,13,13,14,14,15,16,19,
        18,10,11,11,13,13,14,14,16,15,17,18, 0, 0,10,11,
        11,13,13,14,14,15,15,16,18, 0, 0,11,13,13,14,14,
        15,15,17,17, 0,19, 0, 0,11,13,13,14,14,14,15,16,
        18, 0,19, 0, 0,13,14,14,15,15,18,17,18,18, 0,19,
         0, 0,13,14,14,15,16,16,16,18,18,19, 0, 0, 0,16,
        17,17, 0,17,19,19, 0,19, 0, 0, 0, 0,16,19,16,17,
        18, 0,19, 0, 0, 0, 0, 0, 0,
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
