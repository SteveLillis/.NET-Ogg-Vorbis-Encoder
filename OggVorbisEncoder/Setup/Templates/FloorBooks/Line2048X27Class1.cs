namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line2048X27Class1 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        2, 6, 8, 9, 7, 11, 13, 13, 1, 3, 5, 5, 6, 6, 12, 10
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
