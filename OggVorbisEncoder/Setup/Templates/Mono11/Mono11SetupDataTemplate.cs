namespace OggVorbisEncoder.Setup.Templates.Mono11
{
    using System;
    using OggVorbisEncoder.Setup.Templates.Stereo44;

    public class Mono11SetupDataTemplate : ISetupTemplate
    {
        private static readonly double[] SampleRateMapping11Mono = { 12000, 20000, 50000 };
        private static readonly double[] QualityMapping11 = { -0.1, 0.0, 1.0 };
        private static readonly int[] BlockSize11 = { 512, 512 };
        private static readonly AdjBlock[] VpToneMaskAdjLongBlock =
        {
            new AdjBlock(new[] {-20,-20,-20,-20,-20,-16,-10, 0, 0, 0, 0,10, 2, 0,99,99,99}), /* 0 */
            new AdjBlock(new[] {-20,-20,-20,-20,-20,-16,-10, 0, 0, 0, 0, 5, 0, 0,99,99,99}), /* 1 */
            new AdjBlock(new[] {-20,-20,-20,-20,-20,-16,-10, 0, 0, 0, 0, 0, 0, 0,99,99,99}) /* 2 */
        };

        private static readonly int[] NoiseStart8 = { 64, 64 };
        private static readonly int[] NoisePart8 = { 8, 8 };
        private static readonly double[] NoiseThresh11 = { 0.3, 0.5, 0.5 };

        private static readonly int[] FloorMapping11A = { 6, 6 };
        private static readonly int[][] FloorMapping11 =
        {
            FloorMapping11A
        };

        public int Mappings => SampleRateMapping.Length - 1;
        public double[] SampleRateMapping { get; } = SampleRateMapping11Mono;
        public double[] QualityMapping { get; } = QualityMapping11;
        public int CouplingRestriction { get; } = -1;
        public int SampleRateMinRestriction { get; } = 9000;
        public int SampleRateMaxRestriction { get; } = 15000;
        public int[] BlockSizeShort { get; } = BlockSize11;
        public int[] BlockSizeLong { get; } = BlockSize11;
        public Att3[] PsyToneMasterAtt { get; } = Psy11.ToneMasterAtt;
        public int[] PsyTone0Decibel { get; } = Psy.ToneZeroDecibel;
        public int[] PsyToneDecibelSuppress { get; } = Psy.ToneSuppress;
        public AdjBlock[] PsyToneAdjImpulse { get; } = VpToneMaskAdjLongBlock;
        public AdjBlock[] PsyToneAdjLong { get; } = null;
        public AdjBlock[] PsyToneAdjOther { get; } = VpToneMaskAdjLongBlock;
        public NoiseGuard[] PsyNoiseGuards { get; } = Psy8.NoiseGuards;
        public Noise3[] PsyNoiseBiasImpulse { get; } = Psy11.NoiseBias;
        public Noise3[] PsyNoiseBiasPadding { get; } = Psy11.NoiseBias;
        public Noise3[] PsyNoiseBiasTrans { get; } = null;
        public Noise3[] PsyNoiseBiasLong { get; } = null;
        public int[] PsyNoiseDecibelSuppress { get; } = Psy.NoiseSuppress;
        public CompandBlock[] PsyNoiseCompand { get; } = Psy8.Compand;
        public double[] PsyNoiseCompandShortMapping { get; } = Psy8.CompandMapping;
        public double[] PsyNoiseCompandLongMapping { get; } = null;
        public int[][] PsyNoiseNormalStart { get; } = new[] { NoiseStart8, NoiseStart8 };
        public int[][] PsyNoiseNormalPartition { get; } = new[] { NoisePart8, NoisePart8 };
        public double[] PsyNoiseNormalThreshold { get; } = NoiseThresh11;
        public int[] PsyAthFloat { get; } = Psy8.AthFloater;
        public int[] PsyAthAbs { get; } = Psy8.AthAbs;
        public double[] PsyLowPass { get; } = Psy11.Lowpass;
        public PsyGlobal[] GlobalParams { get; } = Psy44.Global;
        public double[] GlobalMapping { get; } = Psy8.GlobalMapping;
        public AdjStereo[] StereoModes { get; } = Psy8.StereoModes;
        public IStaticCodeBook[][] FloorBooks { get; } = SharedFloors.FloorBooks;
        public Floor[] FloorParams { get; } = SharedFloors.Floor;
        public int[][] FloorMappings { get; } = FloorMapping11;
        public IMappingTemplate[] Maps { get; } = Residue8.MapRes8Mono;
    }
}
