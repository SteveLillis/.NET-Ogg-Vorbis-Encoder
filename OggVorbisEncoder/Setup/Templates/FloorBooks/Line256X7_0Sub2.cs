﻿namespace OggVorbisEncoder.Setup.Templates.FloorBooks;

public class Line256X7_0Sub2 : IStaticCodeBook
{
    public int Dimensions { get; } = 1;

    public byte[] LengthList { get; } = {
        0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 4, 3, 4, 3, 5, 3,
        6, 3, 6, 4, 6, 4, 7, 5, 7
    };

    public CodeBookMapType MapType { get; } = CodeBookMapType.None;
    public int QuantMin { get; } = 0;
    public int QuantDelta { get; } = 0;
    public int Quant { get; } = 0;
    public int QuantSequenceP { get; } = 0;
    public int[] QuantList { get; } = null;
}
