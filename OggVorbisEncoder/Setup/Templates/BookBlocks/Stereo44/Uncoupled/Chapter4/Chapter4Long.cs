namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter4;

public class Chapter4Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 8,12,12,13,12,11,13, 5, 4, 6, 7, 8, 8, 9,13,
         9, 5, 4, 5, 5, 7, 9,13, 9, 6, 5, 6, 6, 7, 8,12,
        12, 7, 5, 6, 4, 5, 8,13,11, 7, 6, 6, 5, 5, 6,12,
        10, 8, 8, 7, 7, 5, 3, 8,10,12,13,12,12, 9, 6, 7,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
