namespace OggVorbisEncoder.Setup.Templates.Psyche;

class Psy8
{
    internal static readonly Att3[] ToneMasterAtt ={
        new Att3(new int[]{ 32,  25,  12},  0,   0),
        new Att3(new int[]{ 30,  25,  12},  0,   0),
        new Att3(new int[]{ 20,   0, -14},  0,   0)
    };

    internal static readonly AdjBlock[] VpToneMaskAdjOtherBlock ={
        new AdjBlock(new int[]{-15,-15,-15,-15,-10,-10, -6, 0, 0, 0, 0,10, 0, 0,99,99,99}),
        new AdjBlock(new int[]{-15,-15,-15,-15,-10,-10, -6, 0, 0, 0, 0,10, 0, 0,99,99,99}),
        new AdjBlock(new int[]{-15,-15,-15,-15,-10,-10, -6, 0, 0, 0, 0, 0, 0, 0,99,99,99})
    };

    internal static readonly Noise3[] NoiseBias ={
        new Noise3(new int[][]{
            new int[]{-10,-10,-10,-10, -5, -5, -5,  0,  4,  8,  8,  8, 10, 10, 99, 99, 99},
            new int []{-10,-10,-10,-10, -5, -5, -5,  0,  0,  4,  4,  4,  4,  4, 99, 99, 99},
            new int []{-30,-30,-30,-30,-30,-24,-20,-14,-10, -6, -8, -8, -6, -6, 99, 99, 99}}),

        new Noise3(new int[][]{
            new int[]{-10,-10,-10,-10, -5, -5, -5,  0,  4,  8,  8,  8, 10, 10, 99, 99, 99},
            new int []{-10,-10,-10,-10,-10,-10, -5, -5, -5,  0,  0,  0,  0,  0, 99, 99, 99},
            new int []{-30,-30,-30,-30,-30,-24,-20,-14,-10, -6, -8, -8, -6, -6, 99, 99, 99}}),

        new Noise3(new int[][]{
            new int[]{-15,-15,-15,-15,-15,-12,-10, -8,  0,  2,  4,  4,  5,  5, 99, 99, 99},
            new int []{-30,-30,-30,-30,-26,-22,-20,-14,-12,-12,-10,-10,-10,-10, 99, 99, 99},
            new int []{-30,-30,-30,-30,-26,-26,-26,-26,-26,-26,-26,-26,-26,-24, 99, 99, 99}}),
    };

    internal static readonly AdjStereo[] StereoModes ={
        new AdjStereo(
            new int[]{  4,  4,  4,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3},
            new int[]{  6,  5,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4},
            new float[]{  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1},
            new float[]{ 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99}),

        new AdjStereo(
            new int[]{  4,  4,  4,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3},
            new int[]{  6,  5,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4},
            new float[]{  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1},
            new float[]{ 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99}),

        new AdjStereo(
            new int[]{  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3},
            new int[]{  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4},
            new float[]{  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1},
            new float[]{ 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99})
    };

    internal static readonly NoiseGuard[] NoiseGuards ={
        new NoiseGuard(10,10,-1),
        new NoiseGuard(10,10,-1),
    };

    internal static readonly CompandBlock[] Compand ={
        new CompandBlock(new int[]{
            0, 1, 2, 3, 4, 5, 6,  7,     /* 7dB */
            8, 8, 9, 9,10,10,11, 11,     /* 15dB */
            12,12,13,13,14,14,15, 15,     /* 23dB */
            16,16,17,17,17,18,18, 19,     /* 31dB */
            19,19,20,21,22,23,24, 25,     /* 39dB */
        }),

        new CompandBlock(new int[]{
            0, 1, 2, 3, 4, 5, 6,  6,     /* 7dB */
            7, 7, 6, 6, 5, 5, 4,  4,     /* 15dB */
            3, 3, 3, 4, 5, 6, 7,  8,     /* 23dB */
            9,10,11,12,13,14,15, 16,     /* 31dB */
            17,18,19,20,21,22,23, 24,     /* 39dB */
        })
    };

    internal static readonly double[] Lowpass = { 3.0, 4.0, 4.0 };
    internal static readonly int[] NoiseStart = { 64, 64 };
    internal static readonly int[] NoisePart = { 8, 8 };
    internal static readonly int[] AthFloater = { -100, -100, -105 };
    internal static readonly int[] AthAbs = { -130, -130, -140 };

    internal static readonly int[] BlockSize = { 512, 512 };
    internal static readonly int[] FloorMappingA = { 6, 6 };
    internal static readonly int[][] FloorMapping = { FloorMappingA };
    internal static readonly double[] RateMap_Coupled = { 6000.0, 9000.0, 32000.0 };
    internal static readonly double[] RateMap_Uncoupled = { 8000.0, 14000.0, 42000.0 };
    internal static readonly double[] QualityMapping = { -0.1, 0.0, 1.0 };
    internal static readonly double[] CompandMapping = { 0.0, 1.0, 1.0 };
    internal static readonly double[] GlobalMapping = { 1.0, 2.0, 3.0 };
}
