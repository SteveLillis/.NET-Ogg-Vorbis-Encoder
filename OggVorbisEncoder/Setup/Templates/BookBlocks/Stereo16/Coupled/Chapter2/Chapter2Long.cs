namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Coupled.Chapter2;

public class Chapter2Long : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         4, 7, 9, 9, 9, 8, 9,10,13,16, 5, 4, 5, 6, 7, 7,
         8, 9,12,16, 6, 5, 5, 5, 7, 7, 9,10,12,15, 7, 6,
         5, 4, 5, 6, 8, 9,10,13, 8, 7, 7, 5, 5, 5, 7, 9,
        10,12, 7, 7, 7, 6, 5, 5, 6, 7,10,12, 8, 8, 8, 7,
         7, 5, 5, 6, 9,11, 8, 9, 9, 8, 8, 6, 6, 5, 8,11,
        10,11,12,12,11, 9, 9, 8, 9,12,13,14,15,15,14,12,
        12,11,11,13,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
