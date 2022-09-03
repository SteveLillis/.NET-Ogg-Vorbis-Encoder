namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter7;

public class Chapter7Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         5,12,17,16,16,17,17,17,17,17, 4, 7,11,11,12, 9,
        17,10,17,17, 7, 7, 8, 9, 7, 9,11,10,15,17, 7, 9,
        10,11,10,12,14,12,16,17, 7, 8, 5, 7, 4, 7, 7, 8,
        16,16, 6,10, 9,10, 7,10,11,11,16,17, 6, 8, 8, 9,
         5, 7, 5, 8,16,17, 5, 5, 8, 7, 6, 7, 7, 6, 6,14,
        12,10,12,11, 7,11, 4, 4, 2, 7,17,15,15,15, 8,15,
         6, 8, 5, 9,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
