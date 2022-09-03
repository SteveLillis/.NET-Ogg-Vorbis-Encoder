namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter9;

public class Chapter9Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         9,16,18,18,17,17,17,17,17,17, 5, 8,11,12,11,12,
        17,17,16,16, 6, 6, 8, 8, 9,10,14,15,16,16, 6, 7,
         7, 4, 6, 9,13,16,16,16, 6, 6, 7, 4, 5, 8,11,15,
        17,16, 7, 6, 7, 6, 6, 8, 9,10,14,16,11, 8, 8, 7,
         6, 6, 3, 4,10,15,14,12,12,10, 5, 6, 3, 3, 8,13,
        15,17,15,11, 6, 8, 6, 6, 9,14,17,15,15,12, 8,10,
         9, 9,12,15,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
