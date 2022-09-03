namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter3;

public class Chapter3Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         6, 9,13,12,14,11,10,13, 8, 4, 5, 7, 8, 7, 8,12,
        11, 4, 3, 5, 5, 7, 9,14,11, 6, 5, 6, 6, 6, 7,13,
        13, 7, 5, 6, 4, 5, 7,14,11, 7, 6, 6, 5, 5, 6,13,
         9, 7, 8, 6, 7, 5, 3, 9, 9,12,13,12,14,10, 6, 7,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
