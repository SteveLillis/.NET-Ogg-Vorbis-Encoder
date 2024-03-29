﻿namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line128X17Class3 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        3, 6, 10, 17, 4, 8, 11, 20, 8, 10, 11, 20, 20, 20, 20, 20,
        2, 4, 8, 18, 4, 6, 8, 17, 7, 8, 10, 20, 20, 17, 20, 20,
        3, 5, 8, 17, 3, 4, 6, 17, 8, 8, 10, 17, 17, 12, 16, 20,
        13, 13, 15, 20, 10, 10, 12, 20, 15, 14, 15, 20, 20, 20, 19, 19
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
