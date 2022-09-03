namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo8.Coupled.Chapter1;

public class Page7_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         1, 4, 4, 6, 6, 6, 7, 6, 6, 4, 7, 7,10, 9, 9,10,
         9, 9, 5, 7, 7,10, 9, 9,10, 9, 9, 6,10,10,10,10,
        10,11,10,10, 6, 9, 9,10, 9,10,11,10,10, 6, 9, 9,
        10, 9, 9,11, 9,10, 7,10,10,11,11,11,11,10,10, 6,
         9, 9,10,10,10,11, 9, 9, 6, 9, 9,10,10,10,10, 9,
         9,
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
