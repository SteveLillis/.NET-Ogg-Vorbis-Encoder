namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter5;

public class Page7_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         1, 4, 4, 5, 7, 7, 5, 7, 7, 5, 9, 9, 8,11,10, 7,
        11,10, 5, 9, 9, 7,10,10, 8,10,11, 4, 9, 9, 9,12,
        12, 9,12,12, 8,12,12,11,12,12,10,12,13, 7,12,12,
        11,12,12,10,12,13, 4, 9, 9, 9,12,12, 9,12,12, 7,
        12,11,10,13,13,11,12,12, 7,12,12,10,13,13,11,12,
        12,
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
