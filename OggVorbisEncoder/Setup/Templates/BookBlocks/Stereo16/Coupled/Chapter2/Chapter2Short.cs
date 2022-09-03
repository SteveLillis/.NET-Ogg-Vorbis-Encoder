namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Coupled.Chapter2;

public class Chapter2Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         7,10,12,11,12,13,15,16,18,15,10, 8, 8, 8, 9,10,
        12,13,14,17,10, 7, 7, 7, 7, 8,10,12,15,18,10, 7,
         7, 5, 5, 6, 8,10,13,15,10, 7, 6, 5, 4, 4, 6, 9,
        12,15,11, 7, 7, 5, 4, 3, 4, 7,11,13,12, 9, 8, 7,
         5, 4, 4, 5,10,13,11,11,11, 9, 7, 5, 5, 5, 9,12,
        13,12,13,12,10, 8, 8, 7, 9,13,14,14,14,14,13,11,
        11,10,10,13,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
