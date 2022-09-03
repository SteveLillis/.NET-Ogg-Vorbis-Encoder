namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line128X17_2Sub1 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        0, 4, 5, 4, 6, 4, 8, 3, 9, 3, 9, 2, 9, 3, 8, 4,
        9, 4
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
