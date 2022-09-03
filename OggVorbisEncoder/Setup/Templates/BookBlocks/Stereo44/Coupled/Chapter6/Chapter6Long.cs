namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter6;

public class Chapter6Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 8,11,13,14,14,13,13,16,14, 6, 3, 4, 7, 9, 9,
        10,11,14,13,10, 4, 3, 5, 7, 7, 9,10,13,15,12, 7,
         4, 4, 6, 6, 8,10,13,15,12, 8, 6, 6, 6, 6, 8,10,
        13,14,11, 9, 7, 6, 6, 6, 7, 8,12,11,13,10, 9, 8,
         7, 6, 6, 7,11,11,13,11,10, 9, 9, 7, 7, 6,10,11,
        13,13,13,13,13,11, 9, 8,10,12,12,15,15,16,15,12,
        11,10,10,12,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
