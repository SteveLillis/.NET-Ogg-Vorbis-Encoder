namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter4;

public class Chapter4Short : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
        14,17,15,17,16,14,13,16,10, 7, 7,10,13,10,15,16,
         9, 4, 4, 6, 5, 7, 9,16,12, 8, 7, 8, 8, 8,11,16,
        14, 7, 4, 6, 3, 5, 8,15,13, 8, 5, 7, 4, 5, 7,16,
        12, 9, 6, 8, 3, 3, 5,16,14,13, 7,10, 5, 5, 7,15,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)0;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = null;
}
