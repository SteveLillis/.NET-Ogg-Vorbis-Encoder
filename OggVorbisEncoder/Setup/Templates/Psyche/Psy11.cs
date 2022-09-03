namespace OggVorbisEncoder.Setup.Templates.Psyche;

internal class Psy11
{
    internal static readonly double[] Lowpass = { 4.5, 5.5, 30.0 };

    internal static readonly Att3[] ToneMasterAtt ={
        new Att3(new int[]{ 30,  25,  12},  0,   0),
        new Att3(new int[]{ 30,  25,  12},  0,   0),
        new Att3(new int[]{ 20,   0, -14},  0,   0)
    };

    internal static readonly AdjBlock[] VpToneMaskAdjOtherBlock ={
        new AdjBlock(new int[]{-20,-20,-20,-20,-20,-16,-10, 0, 0, 0, 0,10, 2, 0,99,99,99 }),
        new AdjBlock(new int[]{-20,-20,-20,-20,-20,-16,-10, 0, 0, 0, 0, 5, 0, 0,99,99,99 }),
        new AdjBlock(new int[]{-20,-20,-20,-20,-20,-16,-10, 0, 0, 0, 0, 0, 0, 0,99,99,99 })
    };

    internal static readonly Noise3[] NoiseBias =
    {
        new Noise3(new int[][]{
            new int[]{-10,-10,-10,-10, -5, -5, -5,  0,  4, 10, 10, 12, 12, 12, 99, 99, 99},
            new int[]{-15,-15,-15,-15,-10,-10, -5,  0,  0,  4,  4,  5,  5, 10, 99, 99, 99},
            new int[]{-30,-30,-30,-30,-30,-24,-20,-14,-10, -6, -8, -8, -6, -6, 99, 99, 99}
        }),

        new Noise3(new int[][]{
            new int[]{-10,-10,-10,-10, -5, -5, -5,  0,  4, 10, 10, 12, 12, 12, 99, 99, 99},
            new int[]{-15,-15,-15,-15,-10,-10, -5, -5, -5,  0,  0,  0,  0,  0, 99, 99, 99},
            new int[]{-30,-30,-30,-30,-30,-24,-20,-14,-10, -6, -8, -8, -6, -6, 99, 99, 99},
        }),

        new Noise3(new int[][]{
            new int[]{-15,-15,-15,-15,-15,-12,-10, -8,  0,  2,  4,  4,  5,  5, 99, 99, 99},
            new int[]{-30,-30,-30,-30,-26,-22,-20,-14,-12,-12,-10,-10,-10,-10, 99, 99, 99},
            new int[]{-30,-30,-30,-30,-26,-26,-26,-26,-26,-26,-26,-26,-26,-24, 99, 99, 99},
        })
    };

    internal static readonly double[] NoiseThresh = { .3, .5, .5 };

    internal static readonly int[] BlockSize = { 512, 512 };
    internal static readonly int[] FloorMappingA = { 6, 6 };
    internal static readonly int[][] FloorMapping = { FloorMappingA };
    internal static readonly double[] RateMap_Coupled = { 8000.0, 13000.0, 44000.0 };
    internal static readonly double[] RateMap_Uncoupled = { 12000.0, 20000.0, 50000.0 };
    internal static readonly double[] QualityMapping = { -0.1, 0.0, 1.0 };
}
