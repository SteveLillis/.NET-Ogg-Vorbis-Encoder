namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter3;

public class Chapter3Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
        14,14,14,15,13,15,12,16,10, 8, 7, 9, 9, 8,12,16,
        10, 5, 4, 6, 5, 6, 9,16,14, 8, 6, 8, 7, 8,10,16,
        14, 7, 4, 6, 3, 5, 8,16,15, 9, 5, 7, 4, 4, 7,16,
        13,10, 6, 7, 4, 3, 4,13,13,12, 7, 9, 5, 5, 6,12,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
