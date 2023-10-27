using System;

namespace OggVorbisEncoder;
public static class MathExtensions
{
    public static int SafeAbs(int value)
    {
        // The absolute value of MinValue of int cannot be represented as int
        // So we return a value that's one less than that. This is technically 
        // "incorrect" value, because it's off by one, but for the purposes of representing
        // amplitudes and other values it shouldn't matter
        if (value == int.MinValue)
            return int.MaxValue;

        return Math.Abs(value);
    }
}
