namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter8;

public class Chapter8Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 9,13,14,14,15,14,14,15,15, 5, 4, 6, 8,10,12,
        12,14,15,15, 9, 5, 4, 5, 8,10,11,13,16,16,10, 7,
         4, 3, 5, 7, 9,11,13,13,10, 9, 7, 4, 4, 6, 8,10,
        12,14,13,11, 9, 6, 5, 5, 6, 8,12,14,13,11,10, 8,
         7, 6, 6, 7,10,14,13,11,12,10, 8, 7, 6, 6, 9,13,
        12,11,14,12,11, 9, 8, 7, 9,11,11,12,14,13,14,11,
        10, 8, 8, 9,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
