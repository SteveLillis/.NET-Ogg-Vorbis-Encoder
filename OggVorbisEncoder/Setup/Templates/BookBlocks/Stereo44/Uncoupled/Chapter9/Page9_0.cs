namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter9;

public class Page9_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 3, 3,11,11,11,11,11,11,11,11,11,11,11,11, 4,
        10,11,11,11,11,11,11,11,11,11,11,11,11,11, 4,10,
        10,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,11,
        10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,
        10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,10,
        10,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -510036736;
    public int QuantDelta { get; } = 1631393792;
    public int Quant { get; } = 4;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = {
        7,
        6,
        8,
        5,
        9,
        4,
        10,
        3,
        11,
        2,
        12,
        1,
        13,
        0,
        14,
    };
}
