namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter6;

public class Chapter6Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         4,11,16,13,17,13,17,16,17,17, 4, 7, 9, 9,13,10,
        16,12,16,17, 7, 6, 5, 7, 8, 9,12,12,16,17, 6, 9,
         7, 9,10,10,15,15,17,17, 6, 7, 5, 7, 5, 7, 7,10,
        16,17, 7, 9, 8, 9, 8,10,11,11,15,17, 7, 7, 7, 8,
         5, 8, 8, 9,15,17, 8, 7, 9, 9, 7, 8, 7, 2, 7,15,
        14,13,13,15, 5,10, 4, 3, 6,17,17,15,13,17, 7,11,
         7, 6, 9,16,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
