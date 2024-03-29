namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter7;

public class Chapter7Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 8,11,13,15,14,14,13,15,14, 6, 4, 5, 7, 9,10,
        11,11,14,13,10, 4, 3, 5, 7, 8, 9,10,13,13,12, 7,
         4, 4, 5, 6, 8, 9,12,14,13, 9, 6, 5, 5, 6, 8, 9,
        12,14,12, 9, 7, 6, 5, 5, 6, 8,11,11,12,11, 9, 8,
         7, 6, 6, 7,10,11,13,11,10, 9, 8, 7, 6, 6, 9,11,
        13,13,12,12,12,10, 9, 8, 9,11,12,14,15,15,14,12,
        11,10,10,12,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
