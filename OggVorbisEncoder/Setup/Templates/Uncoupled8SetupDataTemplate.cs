using OggVorbisEncoder.Setup.Templates.Psyche;
using OggVorbisEncoder.Setup.Templates.Residue;

namespace OggVorbisEncoder.Setup.Templates;

public class Uncoupled8SetupDataTemplate : ISetupTemplate
{
    public int Mappings => SampleRateMapping.Length - 1;
    public double[] SampleRateMapping => Psy8.RateMap_Uncoupled;
    public double[] QualityMapping => Psy8.QualityMapping;
    public int CouplingRestriction => -1;
    public int SampleRateMinRestriction => 8000;
    public int SampleRateMaxRestriction => 9000;

    public int[] BlockSizeShort => Psy8.BlockSize;
    public int[] BlockSizeLong => Psy8.BlockSize;

    public Att3[] PsyToneMasterAtt => Psy8.ToneMasterAtt;
    public int[] PsyTone0Decibel => Psy.ToneZeroDecibel;
    public int[] PsyToneDecibelSuppress => Psy.ToneSuppress;

    public AdjBlock[] PsyToneAdjImpulse => Psy8.VpToneMaskAdjOtherBlock;
    public AdjBlock[] PsyToneAdjLong => null;
    public AdjBlock[] PsyToneAdjOther => Psy8.VpToneMaskAdjOtherBlock;

    public NoiseGuard[] PsyNoiseGuards => Psy8.NoiseGuards;
    public Noise3[] PsyNoiseBiasImpulse => Psy8.NoiseBias;
    public Noise3[] PsyNoiseBiasPadding => Psy8.NoiseBias;
    public Noise3[] PsyNoiseBiasTrans => null;
    public Noise3[] PsyNoiseBiasLong => null;
    public int[] PsyNoiseDecibelSuppress => Psy.NoiseSuppress;

    public CompandBlock[] PsyNoiseCompand => Psy8.Compand;
    public double[] PsyNoiseCompandShortMapping => Psy8.CompandMapping;
    public double[] PsyNoiseCompandLongMapping => null;

    public int[][] PsyNoiseNormalStart => new int[][] { Psy8.NoiseStart, Psy8.NoiseStart };
    public int[][] PsyNoiseNormalPartition => new int[][] { Psy8.NoisePart, Psy8.NoisePart };
    public double[] PsyNoiseNormalThreshold => Psy44.NoiseThresh5Only;

    public int[] PsyAthFloat => Psy8.AthFloater;
    public int[] PsyAthAbs => Psy8.AthAbs;

    public double[] PsyLowPass => Psy8.Lowpass;

    public PsyGlobal[] GlobalParams => Psy44.Global;
    public double[] GlobalMapping => Psy8.GlobalMapping;
    public AdjStereo[] StereoModes => Psy8.StereoModes;

    public IStaticCodeBook[][] FloorBooks => SharedFloors.FloorBooks;
    public Floor[] FloorParams => SharedFloors.Floor;
    public int[][] FloorMappings => Psy8.FloorMapping;

    public IMappingTemplate[] Maps => Residue8.MapRes_Uncoupled;
}
