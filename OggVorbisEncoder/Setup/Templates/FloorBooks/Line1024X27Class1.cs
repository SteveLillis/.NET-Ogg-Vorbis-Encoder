namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line1024X27Class1 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        2, 10, 8, 14, 7, 12, 11, 14, 1, 5, 3, 7, 4, 9, 7, 13
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
