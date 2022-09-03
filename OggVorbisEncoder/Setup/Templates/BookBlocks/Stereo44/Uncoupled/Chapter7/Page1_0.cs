namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter7;

public class Page1_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         1, 4, 4, 4, 7, 7, 5, 7, 7, 5, 8, 8, 8,10,10, 7,
        10,10, 5, 8, 8, 7,10,10, 8,10,10, 5, 8, 8, 8,11,
        10, 8,10,10, 8,10,10,10,12,13,10,13,13, 7,10,10,
        10,13,12,10,13,13, 5, 8, 8, 8,11,10, 8,10,11, 7,
        10,10,10,13,13,10,12,13, 8,11,11,10,13,13,10,13,
        12,
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
