namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line1024X27Class4 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        2, 3, 7, 13, 4, 4, 7, 15, 8, 6, 9, 17, 21, 16, 15, 21,
        2, 5, 7, 11, 5, 5, 7, 14, 9, 7, 10, 16, 17, 15, 16, 21,
        4, 7, 10, 17, 7, 7, 9, 15, 11, 9, 11, 16, 21, 18, 15, 21,
        18, 21, 21, 21, 15, 17, 17, 19, 21, 19, 18, 20, 21, 21, 21, 20
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
