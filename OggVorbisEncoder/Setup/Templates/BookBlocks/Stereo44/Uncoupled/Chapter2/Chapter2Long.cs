namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter2;

public class Chapter2Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         5, 9,14,12,15,13,10,13, 7, 4, 5, 6, 8, 7, 8,12,
        13, 4, 3, 5, 5, 6, 9,15,12, 6, 5, 6, 6, 6, 7,14,
        14, 7, 4, 6, 4, 6, 8,15,12, 6, 6, 5, 5, 5, 6,14,
         9, 7, 8, 6, 7, 5, 4,10,10,13,14,14,15,10, 6, 8,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
