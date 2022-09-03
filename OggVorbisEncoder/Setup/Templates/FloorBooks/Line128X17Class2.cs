namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line128X17Class2 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        1, 4, 10, 19, 3, 8, 13, 19, 7, 12, 19, 19, 19, 19, 19, 19,
        2, 6, 11, 19, 8, 13, 19, 19, 9, 11, 19, 19, 19, 19, 19, 19,
        6, 7, 13, 19, 9, 13, 19, 19, 10, 13, 18, 18, 18, 18, 18, 18,
        18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18, 18
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
