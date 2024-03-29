﻿namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line128X4Class0 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        7, 7, 7, 11, 6, 6, 7, 11, 7, 6, 6, 10, 12, 10, 10, 13,
        7, 7, 8, 11, 7, 7, 7, 11, 7, 6, 7, 10, 11, 10, 10, 13,
        10, 10, 9, 12, 9, 9, 9, 11, 8, 8, 8, 11, 13, 11, 10, 14,
        15, 15, 14, 15, 15, 14, 13, 14, 15, 12, 12, 17, 17, 17, 17, 17,
        7, 7, 6, 9, 6, 6, 6, 9, 7, 6, 6, 8, 11, 11, 10, 12,
        7, 7, 7, 9, 7, 6, 6, 9, 7, 6, 6, 9, 13, 10, 10, 11,
        10, 9, 8, 10, 9, 8, 8, 10, 8, 8, 7, 9, 13, 12, 10, 11,
        17, 14, 14, 13, 15, 14, 12, 13, 17, 13, 12, 15, 17, 17, 14, 17,
        7, 6, 6, 7, 6, 6, 5, 7, 6, 6, 6, 6, 11, 9, 9, 9,
        7, 7, 6, 7, 7, 6, 6, 7, 6, 6, 6, 6, 10, 9, 8, 9,
        10, 9, 8, 8, 9, 8, 7, 8, 8, 7, 6, 8, 11, 10, 9, 10,
        17, 17, 12, 15, 15, 15, 12, 14, 14, 14, 10, 12, 15, 13, 12, 13,
        11, 10, 8, 10, 11, 10, 8, 8, 10, 9, 7, 7, 10, 9, 9, 11,
        11, 11, 9, 10, 11, 10, 8, 9, 10, 8, 6, 8, 10, 9, 9, 11,
        14, 13, 10, 12, 12, 11, 10, 10, 8, 7, 8, 10, 10, 11, 11, 12,
        17, 17, 15, 17, 17, 17, 17, 17, 17, 13, 12, 17, 17, 17, 14, 17
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
