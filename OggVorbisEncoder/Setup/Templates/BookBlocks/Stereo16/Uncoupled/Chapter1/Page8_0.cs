namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter1;

public class Page8_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 5, 5, 8, 8,10,10,12,12, 4, 7, 7, 8, 8,
         9, 9,12,11,14,13, 4, 7, 7, 7, 8, 9,10,11,11,13,
        12, 5, 8, 8, 9, 9,11,11,12,13,15,14, 5, 7, 8, 9,
         9,11,11,13,13,17,15, 8, 9,10,11,11,12,13,17,14,
        17,16, 8,10, 9,11,11,12,12,13,15,15,17,10,11,11,
        12,13,14,15,15,16,16,17, 9,11,11,12,12,14,15,17,
        15,15,16,11,14,12,14,15,16,15,16,16,16,15,11,13,
        13,14,14,15,15,16,16,15,16,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -524582912;
    public int QuantDelta { get; } = 1618345984;
    public int Quant { get; } = 4;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = {
        5,
        4,
        6,
        3,
        7,
        2,
        8,
        1,
        9,
        0,
        10,
    };
}
