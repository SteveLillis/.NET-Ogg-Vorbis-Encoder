namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ChapterNeg1;

public class ChapterNeg1Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         4, 4, 7, 8, 7, 8,10,12,17, 3, 1, 6, 6, 7, 8,10,
        12,15, 7, 6, 9, 9, 9,11,12,14,17, 8, 6, 9, 6, 7,
         9,11,13,17, 7, 6, 9, 7, 7, 8, 9,12,15, 8, 8,10,
         8, 7, 7, 7,10,14, 9,10,12,10, 8, 8, 8,10,14,11,
        13,15,13,12,11,11,12,16,17,18,18,19,20,18,16,16,
        20,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
