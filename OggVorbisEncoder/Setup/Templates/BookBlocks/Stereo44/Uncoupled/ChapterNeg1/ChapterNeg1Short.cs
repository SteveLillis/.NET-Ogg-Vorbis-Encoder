namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.ChapterNeg1;

public class ChapterNeg1Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
        12,12,14,12,14,14,14,14,12, 6, 6, 8, 9, 9,11,14,
        12, 4, 2, 6, 6, 7,11,14,13, 6, 5, 7, 8, 9,11,14,
        13, 8, 5, 8, 6, 8,12,14,12, 7, 7, 8, 8, 8,10,14,
        12, 6, 3, 4, 4, 4, 7,14,11, 7, 4, 6, 6, 6, 8,14,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
