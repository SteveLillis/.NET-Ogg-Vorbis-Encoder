namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line128X17_2Sub2 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 5, 1, 5, 3, 5, 3, 5, 4, 7, 5, 10, 7, 10, 7,
        12, 10, 14, 10, 14, 9, 14, 11, 14, 14, 14, 13, 13, 13, 13, 13,
        13, 13
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
