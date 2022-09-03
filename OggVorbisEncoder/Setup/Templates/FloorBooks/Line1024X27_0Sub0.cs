namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line1024X27_0Sub0 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
            5, 5, 5, 5, 6, 5, 6, 5, 6, 5, 6, 5, 6, 5, 6, 5,
        6, 5, 6, 5, 6, 5, 6, 5, 7, 5, 7, 5, 7, 5, 7, 5,
        8, 6, 8, 6, 8, 6, 9, 6, 9, 6, 10, 6, 10, 6, 11, 6,
        11, 7, 11, 7, 12, 7, 12, 7, 12, 7, 12, 7, 12, 7, 12, 7,
        12, 7, 12, 8, 13, 8, 12, 8, 12, 8, 13, 8, 13, 9, 13, 9,
        13, 9, 13, 9, 12, 10, 12, 10, 13, 10, 14, 11, 14, 12, 14, 13,
        14, 13, 14, 14, 15, 16, 15, 15, 15, 14, 15, 17, 21, 22, 22, 21,
        22, 22, 22, 22, 22, 22, 21, 21, 21, 21, 21, 21, 21, 21, 21, 21
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
