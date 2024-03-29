﻿namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line128X7Class0 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        10, 7, 8, 13, 9, 6, 7, 11, 10, 8, 8, 12, 17, 17, 17, 17,
        7, 5, 5, 9, 6, 4, 4, 8, 8, 5, 5, 8, 16, 14, 13, 16,
        7, 5, 5, 7, 6, 3, 3, 5, 8, 5, 4, 7, 14, 12, 12, 15,
        10, 7, 8, 9, 7, 5, 5, 6, 9, 6, 5, 5, 15, 12, 9, 10
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
