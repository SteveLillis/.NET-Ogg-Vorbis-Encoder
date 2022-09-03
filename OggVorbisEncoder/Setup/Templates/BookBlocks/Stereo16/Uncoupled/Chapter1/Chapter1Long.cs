namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter1;

public class Chapter1Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 6,10, 8,12, 8,14, 8,14,19, 5, 3, 5, 5, 7, 6,
        11, 7,16,19, 7, 5, 6, 7, 7, 9,11,12,19,19, 6, 4,
         7, 5, 7, 6,10, 7,18,18, 8, 6, 7, 7, 7, 7, 8, 9,
        18,18, 7, 5, 8, 5, 7, 5, 8, 6,18,18,12, 9,10, 9,
         9, 9, 8, 9,18,18, 8, 7,10, 6, 8, 5, 6, 4,11,18,
        11,15,16,12,11, 8, 8, 6, 9,18,14,18,18,18,16,16,
        16,13,16,18,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
