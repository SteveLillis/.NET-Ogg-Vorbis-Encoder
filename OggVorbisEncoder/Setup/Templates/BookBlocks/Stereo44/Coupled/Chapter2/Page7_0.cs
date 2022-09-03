namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter2;

public class Page7_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         1, 4, 4, 7, 6, 6, 7, 6, 6, 4, 7, 7,10, 9, 9,11,
         9, 9, 4, 7, 7,10, 9, 9,10, 9, 9, 7,10,10,11,10,
        11,11,10,11, 6, 9, 9,11,10,10,11,10,10, 6, 9, 9,
        11,10,11,11,10,10, 7,11,10,11,11,11,12,11,11, 6,
         9, 9,11,10,10,11,11,10, 6, 9, 9,11,10,10,12,10,
        11,
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
