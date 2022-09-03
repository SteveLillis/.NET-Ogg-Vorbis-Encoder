namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Uncoupled.Chapter0;

public class Page5_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 2;

    public byte[] LengthList { get; } = {
         1, 4, 4, 7, 7, 7, 7, 9, 9, 4, 6, 6, 8, 8, 8, 8,
         9, 9, 4, 6, 6, 8, 8, 8, 8, 9, 9, 7, 8, 8, 9, 9,
         9, 9,11,10, 7, 8, 8, 9, 9, 9, 9,10,11, 7, 8, 8,
         9, 9,10,10,11,11, 7, 8, 8, 9, 9,10,10,11,11, 9,
         9, 9,10,10,11,11,12,12, 9, 9, 9,10,10,11,11,12,
        12,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -531628032;
    public int QuantDelta { get; } = 1611661312;
    public int Quant { get; } = 4;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = {
        4,
        3,
        5,
        2,
        6,
        1,
        7,
        0,
        8,
    };
}
