namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line1024X27_2Sub0 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        1, 5, 5, 5, 5, 5, 5, 5, 6, 5, 6, 5, 6, 5, 6, 5,
        6, 6, 7, 7, 7, 7, 8, 7, 8, 8, 9, 8, 10, 9, 10, 9
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
