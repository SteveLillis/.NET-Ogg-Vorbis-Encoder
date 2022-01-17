using OggVorbisEncoder.Setup.Templates.Psyche;
using OggVorbisEncoder.Setup.Templates.Residue;

namespace OggVorbisEncoder.Setup.Templates;

public class Stereo32SetupDataTemplate : ISetupTemplate
{
    public int Mappings => SampleRateMapping.Length - 1;
    public double[] SampleRateMapping { get; } = Psy32.RateMap_Coupled;
    public double[] QualityMapping { get; } = Psy44.QualityMapping;
    public int CouplingRestriction { get; } = 2;
    public int SampleRateMinRestriction { get; } = 26000;
    public int SampleRateMaxRestriction { get; } = 40000;

    public int[] BlockSizeShort { get; } = Psy44.BlockSizeShort;
    public int[] BlockSizeLong { get; } = Psy44.BlockSizeLong;

    public Att3[] PsyToneMasterAtt { get; } = Psy44.ToneMasterAtt;
    public int[] PsyTone0Decibel { get; } = Psy.ToneZeroDecibel;
    public int[] PsyToneDecibelSuppress { get; } = Psy.ToneSuppress;

    public AdjBlock[] PsyToneAdjImpulse { get; } = Psy44.VpToneMaskAdjOtherBlock;
    public AdjBlock[] PsyToneAdjLong { get; } = Psy44.VpToneMaskAdjLongBlock;
    public AdjBlock[] PsyToneAdjOther { get; } = Psy44.VpToneMaskAdjOtherBlock;

    public NoiseGuard[] PsyNoiseGuards { get; } = Psy44.NoiseGuards;
    public Noise3[] PsyNoiseBiasImpulse { get; } = Psy.NoiseBiasImpulse;
    public Noise3[] PsyNoiseBiasPadding { get; } = Psy.NoiseBiasPadding;
    public Noise3[] PsyNoiseBiasTrans { get; } = Psy.NoiseBiasTransition;
    public Noise3[] PsyNoiseBiasLong { get; } = Psy.NoiseBiasLongBlock;
    public int[] PsyNoiseDecibelSuppress { get; } = Psy.NoiseSuppress;

    public CompandBlock[] PsyNoiseCompand { get; } = Psy44.Compand;
    public double[] PsyNoiseCompandShortMapping { get; } = Psy.CompandShortMapping;
    public double[] PsyNoiseCompandLongMapping { get; } = Psy.CompandLongMapping;

    public int[][] PsyNoiseNormalStart { get; } = { Psy44.NoiseStartShort, Psy44.NoiseStartLong };
    public int[][] PsyNoiseNormalPartition { get; } = { Psy44.NoisePartShort, Psy44.NoisePartLong };
    public double[] PsyNoiseNormalThreshold { get; } = Psy44.NoiseThresh;

    public int[] PsyAthFloat { get; } = Psy.AthFloater;
    public int[] PsyAthAbs { get; } = Psy.AthAbs;

    public double[] PsyLowPass { get; } = Psy32.Lowpass;

    public PsyGlobal[] GlobalParams { get; } = Psy44.Global;
    public double[] GlobalMapping { get; } = Psy44.GlobalMapping;
    public AdjStereo[] StereoModes { get; } = Psy44.StereoModes;

    public IStaticCodeBook[][] FloorBooks { get; } = SharedFloors.FloorBooks;
    public Floor[] FloorParams { get; } = SharedFloors.Floor;
    public int[][] FloorMappings { get; } = Psy44.FloorMapping;

    public IMappingTemplate[] Maps { get; } = Residue44.MapRes_Coupled;
}
