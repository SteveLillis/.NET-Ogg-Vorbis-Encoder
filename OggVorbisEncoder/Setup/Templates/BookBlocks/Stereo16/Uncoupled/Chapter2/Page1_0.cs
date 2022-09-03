namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter2;

public class Page1_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         1, 5, 5, 5, 7, 7, 5, 7, 7, 5, 7, 7, 7, 9, 9, 7,
         9, 9, 5, 7, 7, 7, 9, 9, 8, 9, 9, 5, 7, 7, 8, 9,
         9, 7, 9, 9, 7, 9, 9, 9,10,11, 9,10,10, 7, 9, 9,
         9,10, 9, 9,10,11, 5, 8, 7, 7, 9, 9, 8, 9, 9, 7,
         9, 9, 9,11,10, 9, 9,10, 7, 9, 9, 9,10,10, 9,11,
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
