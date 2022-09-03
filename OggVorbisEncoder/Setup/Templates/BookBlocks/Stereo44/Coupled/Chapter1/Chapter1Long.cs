namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter1;

public class Chapter1Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         5, 5, 9,10, 9, 9,10,11,12, 5, 1, 5, 6, 6, 7,10,
        12,14, 9, 5, 6, 8, 8,10,12,14,14,10, 5, 8, 5, 6,
         8,11,13,14, 9, 5, 7, 6, 6, 8,10,12,11, 9, 7, 9,
         7, 6, 6, 7,10,10,10, 9,12, 9, 8, 7, 7,10,12,11,
        11,13,12,10, 9, 8, 9,11,11,14,15,15,13,11, 9, 9,
        11,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
