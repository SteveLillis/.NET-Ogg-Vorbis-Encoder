using System;

namespace OggVorbisEncoder;

internal static class ArrayExtensions
{
    public static TElement[] ToFixedLength<TElement>(this TElement[] input, int fixedLength)
    {
        if (input == null)
            throw new ArgumentNullException(nameof(input));

        if (input.Length == fixedLength)
            return input;

        if (input.Length > fixedLength)
            throw new IndexOutOfRangeException(
                $"{nameof(input)} of size [{input.Length}] is greater than {nameof(fixedLength)} of [{fixedLength}]");

        var output = new TElement[fixedLength];
        Array.Copy(input, output, input.Length);

        return output;
    }
}
