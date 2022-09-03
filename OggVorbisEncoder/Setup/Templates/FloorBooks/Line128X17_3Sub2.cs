namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line128X17_3Sub2 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 5, 3, 6, 3, 6, 4, 7, 4, 7, 4, 7, 4, 8, 4,
        8, 4, 8, 4, 8, 4, 9, 4, 9, 5, 10, 5, 10, 7, 10, 8,
        10, 8
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
