namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line128X11_3Sub2 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 5, 3, 5, 4, 6, 4, 6, 4, 7, 4, 7, 4, 8, 4,
        8, 4, 9, 4, 9, 4, 10, 4, 10, 5, 10, 5, 11, 5, 12, 6,
        12, 6
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
