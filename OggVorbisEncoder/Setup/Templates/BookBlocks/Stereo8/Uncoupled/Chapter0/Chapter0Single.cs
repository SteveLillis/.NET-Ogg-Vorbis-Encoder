namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo8.Uncoupled.Chapter0;

public class Chapter0Single : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         4, 7,11, 9,12, 8, 7,10, 6, 4, 5, 5, 7, 5, 6,16,
         9, 5, 5, 6, 7, 7, 9,16, 7, 4, 6, 5, 7, 5, 7,17,
        10, 7, 7, 8, 7, 7, 8,18, 7, 5, 6, 4, 5, 4, 5,15,
         7, 6, 7, 5, 6, 4, 5,15,12,13,18,12,17,11, 9,17,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
