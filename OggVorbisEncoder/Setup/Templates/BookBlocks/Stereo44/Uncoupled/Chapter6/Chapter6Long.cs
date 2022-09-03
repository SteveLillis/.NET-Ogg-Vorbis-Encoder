namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter6;

public class Chapter6Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 9,14,13,14,13,16,12,13,14, 5, 4, 6, 6, 8, 9,
        11,10,12,15,10, 5, 5, 6, 6, 8,10,10,13,16,10, 6,
         6, 6, 6, 8, 9, 9,12,14,13, 7, 6, 6, 4, 6, 6, 7,
        11,14,10, 7, 7, 7, 6, 6, 6, 7,10,13,15,10, 9, 8,
         5, 6, 5, 6,10,14,10, 9, 8, 8, 6, 6, 5, 4, 6,11,
        11,11,12,11,10, 9, 9, 5, 5, 9,10,12,15,13,13,13,
        13, 8, 7, 7,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
