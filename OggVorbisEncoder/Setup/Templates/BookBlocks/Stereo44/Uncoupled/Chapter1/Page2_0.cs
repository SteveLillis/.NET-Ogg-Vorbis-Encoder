namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter1;

public class Page2_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         2, 4, 4, 5, 6, 6, 5, 6, 6, 5, 7, 7, 7, 8, 8, 6,
         8, 8, 5, 7, 7, 6, 8, 8, 7, 8, 8, 4, 7, 7, 7, 8,
         8, 7, 8, 8, 7, 8, 8, 8, 9,10, 8,10,10, 6, 8, 8,
         8,10, 8, 8,10,10, 5, 7, 7, 7, 8, 8, 7, 8, 8, 6,
         8, 8, 8,10,10, 8, 8,10, 6, 8, 8, 8,10,10, 8,10,
         9,
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
