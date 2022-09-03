namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line512X17_1Sub0 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        2, 4, 5, 4, 5, 4, 5, 4, 5, 5, 5, 5, 5, 5, 6, 5,
        6, 5, 6, 6, 7, 6, 7, 6, 8, 7, 8, 7, 8, 7, 8, 7
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
