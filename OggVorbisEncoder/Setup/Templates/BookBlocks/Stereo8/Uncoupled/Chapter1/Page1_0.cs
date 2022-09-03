namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo8.Uncoupled.Chapter1;

public class Page1_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         1, 4, 4, 5, 7, 7, 5, 7, 7, 5, 8, 8, 7, 9,10, 7,
         9, 9, 5, 8, 8, 7,10, 9, 7, 9, 9, 5, 8, 8, 8,10,
        10, 8,10,10, 7,10,10, 9,10,12,10,12,12, 7,10,10,
         9,12,11,10,12,12, 5, 8, 8, 8,10,10, 8,10,10, 7,
        10,10,10,12,12, 9,11,12, 7,10,10,10,12,12, 9,12,
        10,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -535822336;
    public int QuantDelta { get; } = 1611661312;
    public int Quant { get; } = 2;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = {
        1,
        0,
        2,
    };
}
