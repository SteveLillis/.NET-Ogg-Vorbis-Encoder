namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter8;

public class Chapter8Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 8,12,13,14,14,14,13,14,14, 6, 4, 5, 8,10,10,
        11,11,14,13, 9, 5, 4, 5, 7, 8, 9,10,13,13,12, 7,
         5, 4, 5, 6, 8, 9,12,13,13, 9, 6, 5, 5, 5, 7, 9,
        11,14,12,10, 7, 6, 5, 4, 6, 7,10,11,12,11, 9, 8,
         7, 5, 5, 6,10,10,13,12,10, 9, 8, 6, 6, 5, 8,10,
        14,13,12,12,11,10, 9, 7, 8,10,12,13,14,14,13,12,
        11, 9, 9,10,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
