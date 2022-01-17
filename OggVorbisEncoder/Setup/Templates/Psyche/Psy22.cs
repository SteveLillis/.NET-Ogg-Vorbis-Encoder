using System;
using System.Collections.Generic;
using System.Text;

namespace OggVorbisEncoder.Setup.Templates.Psyche;

internal class Psy22
{
    internal static readonly double[] RateMap_Coupled = { 15000.0, 20000.0, 44000.0, 86000.0 };
    internal static readonly double[] RateMap_Uncoupled = { 16000.0, 28000.0, 50000.0, 90000.0 };
    internal static readonly double[] Lowpass = { 9.5, 11.0, 30.0, 99.0 };
}
