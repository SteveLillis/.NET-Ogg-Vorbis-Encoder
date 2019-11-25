[Available on NuGet](https://www.nuget.org/packages/OggVorbisEncoder/)

.NET Ogg Vorbis Encoder
=======================
A .NET Core [Ogg Vorbis](https://xiph.org/vorbis/) audio encoding library written entirely in managed code.

How to use
----------
The code makes heavy use of C# 6 features, so you'll need Visual Studio 2015 or later if you want to work with the source.  You can [download the free Community edition here](https://www.microsoft.com/en-us/download/details.aspx?id=48146).

For a demonstration of how to implement the encoder library, see [the included example](OggVorbisEncoder.Example/Encoder.cs).  Note that the file `unencoded.raw` must be in the current working directory for the example to find it.


Encodings
-----------
Currently supports the following encodings:

| Sample Rate |    Range    | Channels | Supported | 
|-------------|-------------|----------|-----------|
|    44100    |  (40k-50k)  |     1    |  [x] Yes
|    44100    |  (40k-50k)  |     2    |  [x] Yes
|    44100    |  (40k-50k)  |    5.1   |  [-] Non-Optimal
|    32000    |  (26k-40k)  |     1    |  [x] Yes
|    32000    |  (26k-40k)  |     2    |  [x] Yes
|    22050    |  (19k-26k)  |     1    |  [x] Yes
|    22050    |  (19k-26k)  |     2    |  [x] Yes
|    16000    |  (15k-19k)  |     1    |  [x] Yes
|    16000    |  (15k-19k)  |     2    |  [x] Yes
|    11025    |   (9k-15k)  |     1    |  [x] Yes
|    11025    |   (9k-15k)  |     2    |  [x] Yes
|     8000    |   (8k-9k)   |     1    |  [x] Yes
|     8000    |   (8k-9k)   |     2    |  [x] Yes
|        X    |  (50k-200k) |     1    |  [x] Yes
|        X    |  (50k-200k) |     2    |  [x] Yes
|       XX    |   (0k-8k)   |     1    |  [x] Yes
|       XX    |   (0k-8k)   |     2    |  [x] Yes