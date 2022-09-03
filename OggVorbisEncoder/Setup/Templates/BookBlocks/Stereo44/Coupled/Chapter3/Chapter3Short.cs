namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter3;

public class Chapter3Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
        10, 9,13,11,14,10,12,13,13,14, 7, 2,12, 5,10, 5,
         7,10,12,14,12, 6, 9, 8, 7, 7, 9,11,13,16,10, 4,
        12, 5,10, 6, 8,12,14,16,12, 6, 8, 7, 6, 5, 7,11,
        12,16,10, 4, 8, 5, 6, 4, 6, 9,13,16,10, 6,10, 7,
         7, 6, 7, 9,13,15,12, 9,11, 9, 8, 6, 7,10,12,14,
        14,11,10, 9, 6, 5, 6, 9,11,13,15,13,11,10, 6, 5,
         6, 8, 9,11,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
