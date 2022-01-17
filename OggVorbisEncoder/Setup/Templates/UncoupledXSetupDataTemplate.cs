using OggVorbisEncoder.Setup.Templates.Psyche;
using OggVorbisEncoder.Setup.Templates.Residue;

namespace OggVorbisEncoder.Setup.Templates;

public class UncoupledXSetupDataTemplate : ISetupTemplate
{
    public int Mappings => SampleRateMapping.Length - 1;
    public double[] SampleRateMapping => PsyX.RateMap;
    public double[] QualityMapping => Psy44.QualityMapping;
    public int CouplingRestriction => -1;
    public int SampleRateMinRestriction => 50000;
    public int SampleRateMaxRestriction => 200000;

    public int[] BlockSizeShort => Psy44.BlockSizeShort;
    public int[] BlockSizeLong => Psy44.BlockSizeLong;

    public Att3[] PsyToneMasterAtt => Psy44.ToneMasterAtt;
    public int[] PsyTone0Decibel => Psy.ToneZeroDecibel;
    public int[] PsyToneDecibelSuppress => Psy.ToneSuppress;

    public AdjBlock[] PsyToneAdjImpulse => Psy44.VpToneMaskAdjOtherBlock;
    public AdjBlock[] PsyToneAdjLong => Psy44.VpToneMaskAdjLongBlock;
    public AdjBlock[] PsyToneAdjOther => Psy44.VpToneMaskAdjOtherBlock;

    public NoiseGuard[] PsyNoiseGuards => Psy44.NoiseGuards;
    public Noise3[] PsyNoiseBiasImpulse => Psy.NoiseBiasImpulse;
    public Noise3[] PsyNoiseBiasPadding => Psy.NoiseBiasPadding;
    public Noise3[] PsyNoiseBiasTrans => Psy.NoiseBiasTransition;
    public Noise3[] PsyNoiseBiasLong => Psy.NoiseBiasLongBlock;
    public int[] PsyNoiseDecibelSuppress => Psy.NoiseSuppress;

    public CompandBlock[] PsyNoiseCompand => Psy44.Compand;
    public double[] PsyNoiseCompandShortMapping => Psy.CompandShortMapping;
    public double[] PsyNoiseCompandLongMapping => Psy.CompandLongMapping;

    public int[][] PsyNoiseNormalStart => new int[][] { Psy44.NoiseStartShort, Psy44.NoiseStartLong };
    public int[][] PsyNoiseNormalPartition => new int[][] { Psy44.NoisePartLong, Psy44.NoisePartLong };
    public double[] PsyNoiseNormalThreshold => Psy44.NoiseThresh;

    public int[] PsyAthFloat => Psy.AthFloater;
    public int[] PsyAthAbs => Psy.AthAbs;

    public double[] PsyLowPass => Psy44.Lowpass;

    public PsyGlobal[] GlobalParams => Psy44.Global;
    public double[] GlobalMapping => Psy44.GlobalMapping;
    public AdjStereo[] StereoModes => Psy44.StereoModes;

    public IStaticCodeBook[][] FloorBooks => SharedFloors.FloorBooks;
    public Floor[] FloorParams => SharedFloors.Floor;
    public int[][] FloorMappings => Psy44.FloorMapping;

    public IMappingTemplate[] Maps => Residue44.MapRes_Uncoupled;
}
