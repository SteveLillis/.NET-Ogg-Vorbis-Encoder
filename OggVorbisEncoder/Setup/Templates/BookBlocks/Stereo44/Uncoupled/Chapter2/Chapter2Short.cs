namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter2;

public class Chapter2Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
        13,15,17,17,15,15,12,17,11, 9, 7,10,10, 9,12,17,
        10, 6, 3, 6, 5, 7,10,17,15,10, 6, 9, 8, 9,11,17,
        15, 8, 4, 7, 3, 5, 9,16,16,10, 5, 8, 4, 5, 8,16,
        13,11, 5, 8, 3, 3, 5,14,13,12, 7,10, 5, 5, 7,14,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
