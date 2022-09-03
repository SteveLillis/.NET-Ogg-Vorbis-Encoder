namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line512X17_3Sub2 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 2, 3, 3, 4, 3, 5, 4, 6, 4, 6, 5, 7, 6, 7,
        6, 8, 6, 8, 7, 9, 8, 10, 8, 12, 9, 13, 10, 15, 10, 15,
        11, 14
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
