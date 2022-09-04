﻿namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line128X7_0Sub3 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 5, 3, 5, 3, 5, 4,
        5, 4, 5, 5, 5, 5, 6, 5, 6, 5, 6, 5, 6, 5, 6, 5,
        7, 8, 9, 11, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
