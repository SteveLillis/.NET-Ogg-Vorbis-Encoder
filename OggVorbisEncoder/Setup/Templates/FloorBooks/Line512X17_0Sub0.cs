namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line512X17_0Sub0 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
        5, 6, 5, 6, 6, 6, 6, 5, 6, 6, 7, 6, 7, 6, 7, 6,
        7, 6, 8, 7, 8, 7, 8, 7, 8, 7, 8, 7, 9, 7, 9, 7,
        9, 7, 9, 8, 9, 8, 10, 8, 10, 8, 10, 7, 10, 6, 10, 8,
        10, 8, 11, 7, 10, 7, 11, 8, 11, 11, 12, 12, 11, 11, 12, 11,
        13, 11, 13, 11, 13, 12, 15, 12, 13, 13, 14, 14, 14, 14, 14, 15,
        15, 15, 16, 14, 17, 19, 19, 18, 18, 18, 18, 18, 18, 18, 18, 18,
        18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
