namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter7;

public class Chapter7Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 9,14,13,15,14,16,13,13,14, 5, 5, 7, 7, 8, 9,
        11,10,12,15,10, 6, 5, 6, 6, 9,10,10,13,16,10, 6,
         6, 6, 6, 8, 9, 9,12,15,14, 7, 6, 6, 5, 6, 6, 8,
        12,15,10, 8, 7, 7, 6, 7, 7, 7,11,13,14,10, 9, 8,
         5, 6, 4, 5, 9,12,10, 9, 9, 8, 6, 6, 5, 3, 6,11,
        12,11,12,12,10, 9, 8, 5, 5, 8,10,11,15,13,13,13,
        12, 8, 6, 7,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
