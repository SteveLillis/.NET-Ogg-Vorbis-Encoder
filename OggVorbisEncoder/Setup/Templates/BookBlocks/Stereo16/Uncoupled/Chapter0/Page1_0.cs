namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter0;

public class Page1_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         1, 4, 4, 5, 7, 7, 5, 7, 8, 5, 8, 8, 8,10,10, 8,
        10,11, 5, 8, 8, 8,10,10, 8,10,10, 4, 9, 9, 9,12,
        11, 8,11,11, 8,12,11,10,12,14,10,13,13, 7,11,11,
        10,14,12,11,14,14, 4, 9, 9, 8,11,11, 9,11,12, 7,
        11,11,10,13,14,10,12,14, 8,11,12,10,14,14,10,13,
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
