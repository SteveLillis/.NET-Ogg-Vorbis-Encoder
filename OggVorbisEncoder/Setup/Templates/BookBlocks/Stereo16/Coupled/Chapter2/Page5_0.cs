namespace OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16.Coupled.Chapter2;

public class Page5_0 : IStaticCodeBook
{
    public int Dimensions { get; } = 4;

    public byte[] LengthList { get; } = {
         1, 4, 4, 5, 7, 7, 6, 7, 7, 4, 6, 6,10,11,10,10,
        10,11, 4, 6, 6,10,10,11,10,11,10, 5,10,10, 9,12,
        11,10,12,12, 7,10,10,12,12,12,12,13,13, 7,11,10,
        11,12,12,12,13,13, 6,11,10,10,12,12,11,12,12, 7,
        11,10,12,13,13,12,12,12, 7,10,11,12,13,13,12,12,
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
