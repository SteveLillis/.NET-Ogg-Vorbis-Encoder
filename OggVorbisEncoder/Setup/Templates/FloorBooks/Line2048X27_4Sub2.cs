namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line2048X27_4Sub2 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 3, 2, 4, 3, 4, 4, 4, 5, 5, 6, 5, 6, 5, 7,
        6, 6, 6, 7, 7, 7, 8, 9, 9, 9, 12, 10, 11, 10, 10, 12,
        10, 10
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
