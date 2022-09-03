namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line2048X27Class4 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        2, 4, 7, 13, 4, 5, 7, 15, 8, 7, 10, 16, 16, 14, 16, 16,
        2, 4, 7, 16, 3, 4, 7, 14, 8, 8, 10, 16, 16, 16, 15, 16,
        6, 8, 11, 16, 7, 7, 9, 16, 11, 9, 13, 16, 16, 16, 15, 16,
        16, 16, 16, 16, 14, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
