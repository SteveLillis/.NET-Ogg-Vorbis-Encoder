namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter7;

public class Page7_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         1, 4, 4, 5, 7, 7, 5, 7, 7, 5, 9, 8, 8, 9, 9, 7,
        10,10, 5, 8, 9, 7, 9,10, 8, 9, 9, 4, 9, 9, 9,11,
        10, 8,10,10, 7,11,10,10,10,12,10,12,12, 7,10,10,
        10,12,11,10,12,12, 5, 9, 9, 8,10,10, 9,11,11, 7,
        11,10,10,12,12,10,11,12, 7,10,11,10,12,12,10,12,
        10,
    };

    public CodeBookMapType MapType { get; } = (CodeBookMapType)1;
    public int QuantMin { get; } = -529137664;
    public int QuantDelta { get; } = 1618345984;
    public int Quant { get; } = 2;
    public int QuantSequenceP { get; } = 0;

    public int[] QuantList { get; } = {
        1,
        0,
        2,
    };
}
