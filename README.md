[Available on NuGet](https://www.nuget.org/packages/OggVorbisEncoder/)

.NET Ogg Vorbis Encoder
=======================
A .NET Core [Ogg Vorbis](https://xiph.org/vorbis/) audio encoding library written entirely in managed code.

How to use
----------
The code makes heavy use of C# 6 features, so you'll need Visual Studio 2015 or later if you want to work with the source.  You can [download the free Community edition here](https://www.microsoft.com/en-us/download/details.aspx?id=48146).

For a demonstration of how to implement the encoder library, see [the included example](OggVorbisEncoder.Example/Encoder.cs).  Note that the file `unencoded.raw` must be in the current working directory for the example to find it.


Limitations
-----------
 - Currently only supports **40k+ Stereo VBR** encoding.  If you need another format you just need to add the required setup data, feel free to raise a Pull Request, or contact me if you need more information.
