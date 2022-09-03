namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.ChapterNeg1;

public class ChapterNeg1Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         5, 6,12, 9,14, 9, 9,19, 6, 1, 5, 5, 8, 7, 9,19,
        12, 4, 4, 7, 7, 9,11,18, 9, 5, 6, 6, 8, 7, 8,17,
        14, 8, 7, 8, 8,10,12,18, 9, 6, 8, 6, 8, 6, 8,18,
         9, 8,11, 8,11, 7, 5,15,16,18,18,18,17,15,11,18,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
