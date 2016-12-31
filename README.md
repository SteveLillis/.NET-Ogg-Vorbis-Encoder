[Available on NuGet](https://www.nuget.org/packages/OggVorbisEncoder/)

.NET Ogg Vorbis Encoder
=======================
An [Ogg Vorbis](https://xiph.org/vorbis/) audio encoding library written entirely in managed code.

How to use
----------
The code makes heavy use of C# 6 features, so you'll need Visual Studio 2015 or later, you can [download the free Community edition here](https://www.microsoft.com/en-us/download/details.aspx?id=48146).

See [the included example](OggVorbisEncoder.Example/Encoder.cs) for a demonstration of how to implement the encoder.

Limitations
-----------
 - Currently only supports **40k+ Stereo VBR** encoding.  If you need another format, let me know.
