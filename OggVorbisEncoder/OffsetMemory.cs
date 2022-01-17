using System;

namespace OggVorbisEncoder;

public class OffsetMemory<T>
{
    private readonly Memory<T> _memory;

    public OffsetMemory(in Memory<T> memory, int offset)
    {
        _memory = memory;
        Offset = offset;
    }

    public int Offset { get; }

    public T this[int index]
    {
        get { return _memory.Span[index]; }
    }
}
