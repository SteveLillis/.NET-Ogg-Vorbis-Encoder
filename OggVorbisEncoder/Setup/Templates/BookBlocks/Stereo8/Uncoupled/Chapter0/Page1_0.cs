namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo8.Uncoupled.Chapter0;

public class Page1_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         1, 4, 4, 5, 7, 7, 5, 7, 7, 5, 8, 8, 8,10,10, 7,
        10,10, 5, 8, 8, 7,10,10, 8,10,10, 4, 9, 8, 8,11,
        11, 8,11,11, 7,11,11,10,11,13,10,13,13, 7,11,11,
        10,13,12,10,13,13, 5, 9, 8, 8,11,11, 8,11,11, 7,
        11,11, 9,13,13,10,12,13, 7,11,11,10,13,13,10,13,
        11,
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
