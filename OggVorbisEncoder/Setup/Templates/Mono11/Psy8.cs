// TODO: If we decide to move to port data for 8KHz, we should move this definition there

namespace OggVorbisEncoder.Setup.Templates.Mono11
{
    public static class Psy8
    {
        public static readonly NoiseGuard[] NoiseGuards =
        {
            new NoiseGuard(10, 10, -1),
            new NoiseGuard(10, 10, -1)
        };

        public static readonly CompandBlock[] Compand =
        {
            /* sub-mode Z short */
            new CompandBlock(new[]
            {
                0, 1, 2, 3, 4, 5, 6,  7,      /* 7dB */
                8, 8, 9, 9,10,10,11, 11,      /* 15dB */
                12,12,13,13,14,14,15, 15,     /* 23dB */
                16,16,17,17,17,18,18, 19,     /* 31dB */
                19,19,20,21,22,23,24, 25,     /* 39dB */
            }),
            new CompandBlock(new[]
            {
                0, 1, 2, 3, 4, 5, 6,  6,     /* 7dB */
                7, 7, 6, 6, 5, 5, 4,  4,     /* 15dB */
                3, 3, 3, 4, 5, 6, 7,  8,     /* 23dB */
                9,10,11,12,13,14,15, 16,     /* 31dB */
                17,18,19,20,21,22,23, 24,    /* 39dB */
            }),
        };

        public static double[] CompandMapping = new double[] { 0.0, 1.0, 1.0 };

        public static readonly int[] AthFloater = { -100, -100, -105 };

        public static readonly int[] AthAbs = { -130, -130, -140 };

        public static readonly double[] GlobalMapping = { 1.0, 2.0, 3.0 };

        public static readonly AdjStereo[] StereoModes =
        {
            new AdjStereo(
                new int[] {  4,  4,  4,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3},
                new int[] {  6,  5,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4},
                new float[] {  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1},
                new float[] { 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99}),
            new AdjStereo(new int[] {  4,  4,  4,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3},
                new int[] {  6,  5,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4},
                new float[] {  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1},
                new float[] { 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99}),
            new AdjStereo(new int[] {  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3,  3},
                new int[] {  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4,  4},
                new float[] {  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1,  1},
                new float[] { 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99, 99}),
        };
    }
}
