namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter1;

public class Chapter1Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         5, 7,10, 9,11,10,15,11,13,16, 6, 4, 6, 6, 7, 7,
        10, 9,12,16,10, 6, 5, 6, 6, 7,10,11,16,16, 9, 6,
         7, 6, 7, 7,10, 8,14,16,11, 6, 5, 4, 5, 6, 8, 9,
        15,16, 9, 6, 6, 5, 6, 6, 9, 8,14,16,12, 7, 6, 6,
         5, 6, 6, 7,13,16, 8, 6, 7, 6, 5, 5, 4, 4,11,16,
         9, 8, 9, 9, 7, 7, 6, 5,13,16,14,14,16,15,16,15,
        16,16,16,16,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
