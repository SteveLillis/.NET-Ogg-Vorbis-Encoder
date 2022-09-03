namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line128X4Sub3 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 4, 3, 5, 3, 5, 3,
        5, 4, 6, 5, 6, 5, 7, 6, 6, 7, 7, 9, 9, 11, 11, 16,
        11, 14, 10, 11, 11, 13, 16, 15, 15, 15, 15, 15, 15, 15, 15, 15
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
