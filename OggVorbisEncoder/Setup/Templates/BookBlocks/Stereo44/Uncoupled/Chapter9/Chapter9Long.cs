namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter9;

public class Chapter9Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 9,13,13,14,15,14,14,15,15, 5, 5, 9,10,12,12,
        13,14,16,15,10, 6, 6, 6, 8,11,12,13,16,15,11, 7,
         5, 3, 5, 8,10,12,15,15,10,10, 7, 4, 3, 5, 8,10,
        12,12,12,12, 9, 7, 5, 4, 6, 8,10,13,13,12,11, 9,
         7, 5, 5, 6, 9,12,14,12,12,10, 8, 6, 6, 6, 7,11,
        13,12,14,13,10, 8, 7, 7, 7,10,11,11,12,13,12,11,
        10, 8, 8, 9,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
