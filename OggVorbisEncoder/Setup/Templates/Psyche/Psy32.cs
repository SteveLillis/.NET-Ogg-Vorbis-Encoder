using System;
using System.Collections.Generic;
using System.Text;

namespace OggVorbisEncoder.Setup.Templates.Psyche;

internal static class Psy32
{
    internal static readonly double[] RateMap_Coupled ={
        18000.0,28000.0,35000.0,45000.0,56000.0,60000.0,
        75000.0,90000.0,100000.0,115000.0,150000.0,190000.0,
    };

    internal static readonly double[] RateMap_Uncoupled ={
        30000.0,42000.0,52000.0,64000.0,72000.0,78000.0,
        86000.0,92000.0,110000.0,120000.0,140000.0,190000.0,
    };

    internal static readonly double[] Lowpass = { 12.3, 13.0, 13.0, 14.0, 15.0, 99.0, 99.0, 99.0, 99.0, 99.0, 99.0, 99.0 };
}
