namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo8.Uncoupled.Chapter1;

public class Chapter1Single : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         4, 7,13, 9,15, 9,16, 8,10,13, 7, 5, 8, 6, 9, 7,
        10, 7,10,11,11, 6, 7, 8, 8, 9, 9, 9,12,16, 8, 5,
         8, 6, 8, 6, 9, 7,10,12,11, 7, 7, 7, 6, 7, 7, 7,
        11,15, 7, 5, 8, 6, 7, 5, 7, 6, 9,13,13, 9, 9, 8,
         6, 6, 5, 5, 9,14, 8, 6, 8, 6, 6, 4, 5, 3, 5,13,
         9, 9,11, 8,10, 7, 8, 4, 5,12,11,16,17,15,17,12,
        13, 8, 8,15,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
