namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter6;

public class Page7_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         1, 4, 4, 5, 7, 7, 5, 7, 7, 5, 9, 8, 7,10,10, 8,
        10,10, 5, 8, 9, 7,10,10, 7,10, 9, 4, 8, 8, 9,11,
        11, 8,11,11, 7,11,11,10,10,13,10,13,13, 7,11,11,
        10,13,12,10,13,13, 5, 9, 8, 8,11,11, 9,11,11, 7,
        11,11,10,13,13,10,12,13, 7,11,11,10,13,13, 9,13,
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
