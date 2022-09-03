namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Coupled.Chapter0;

public class Chapter0Single : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         3, 4,19, 7, 9, 7, 8,11, 9,12, 4, 1,19, 6, 7, 7,
         8,10,11,13,18,18,18,18,18,18,18,18,18,18, 8, 6,
        18, 8, 9, 9,11,12,14,18, 9, 6,18, 9, 7, 8, 9,11,
        12,18, 7, 6,18, 8, 7, 7, 7, 9,11,17, 8, 8,18, 9,
         7, 6, 6, 8,11,17,10,10,18,12, 9, 8, 7, 9,12,18,
        13,15,18,15,13,11,10,11,15,18,14,18,18,18,18,18,
        16,16,18,18,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
