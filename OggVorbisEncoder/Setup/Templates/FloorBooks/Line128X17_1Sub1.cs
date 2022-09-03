namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line128X17_1Sub1 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        4, 3, 5, 3, 5, 3, 6, 3, 6, 4, 6, 4, 7, 4, 7, 5,
        8, 5, 8, 6, 9, 7, 9, 7, 9, 8, 10, 9, 10, 9, 11, 10,
        11, 11, 11, 11, 11, 11, 12, 12, 12, 13, 12, 13, 12, 14, 12, 15,
        12, 14, 12, 16, 13, 17, 13, 17, 14, 17, 14, 16, 13, 17, 14, 17,
        14, 17, 15, 17, 15, 15, 16, 17, 17, 17, 17, 17, 17, 17, 17, 17,
        17, 17, 17, 17, 17, 17, 16, 16, 16, 16, 16, 16, 16, 16, 16, 16
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
