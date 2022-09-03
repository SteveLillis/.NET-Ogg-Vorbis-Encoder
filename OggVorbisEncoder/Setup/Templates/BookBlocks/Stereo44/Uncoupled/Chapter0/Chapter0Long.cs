namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter0;

public class Chapter0Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         5, 8,13,10,17,11,11,15, 7, 2, 4, 5, 8, 7, 9,16,
        13, 4, 3, 5, 6, 8,11,20,10, 4, 5, 5, 7, 6, 8,18,
        15, 7, 6, 7, 8,10,14,20,10, 6, 7, 6, 9, 7, 8,17,
         9, 8,10, 8,10, 5, 4,11,12,17,19,14,16,10, 7,12,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
