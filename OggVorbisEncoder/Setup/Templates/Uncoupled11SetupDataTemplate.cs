using OggVorbisEncoder.Setup.Templates.Psyche;
using OggVorbisEncoder.Setup.Templates.Residue;

namespace OggVorbisEncoder.Setup.Templates;

public class Uncoupled11SetupDataTemplate : ISetupTemplate
{
    public int Mappings => SampleRateMapping.Length - 1;
    public double[] SampleRateMapping => Psy11.RateMap_Uncoupled;
    public double[] QualityMapping => Psy11.QualityMapping;
    public int CouplingRestriction => -1;
    public int SampleRateMinRestriction => 9000;
    public int SampleRateMaxRestriction => 15000;

    public int[] BlockSizeShort => Psy11.BlockSize;
    public int[] BlockSizeLong => Psy11.BlockSize;

    public Att3[] PsyToneMasterAtt => Psy11.ToneMasterAtt;
    public int[] PsyTone0Decibel => Psy.ToneZeroDecibel;
    public int[] PsyToneDecibelSuppress => Psy.ToneSuppress;

    public AdjBlock[] PsyToneAdjImpulse => Psy11.VpToneMaskAdjOtherBlock;
    public AdjBlock[] PsyToneAdjLong => null;
    public AdjBlock[] PsyToneAdjOther => Psy11.VpToneMaskAdjOtherBlock;

    public NoiseGuard[] PsyNoiseGuards => Psy8.NoiseGuards;
    public Noise3[] PsyNoiseBiasImpulse => Psy11.NoiseBias;
    public Noise3[] PsyNoiseBiasPadding => Psy11.NoiseBias;
    public Noise3[] PsyNoiseBiasTrans => null;
    public Noise3[] PsyNoiseBiasLong => null;
    public int[] PsyNoiseDecibelSuppress => Psy.NoiseSuppress;

    public CompandBlock[] PsyNoiseCompand => Psy8.Compand;
    public double[] PsyNoiseCompandShortMapping => Psy8.CompandMapping;
    public double[] PsyNoiseCompandLongMapping => null;

    public int[][] PsyNoiseNormalStart => new int[][] { Psy8.NoiseStart, Psy8.NoiseStart };
    public int[][] PsyNoiseNormalPartition => new int[][] { Psy8.NoisePart, Psy8.NoisePart };
    public double[] PsyNoiseNormalThreshold => Psy11.NoiseThresh;

    public int[] PsyAthFloat => Psy8.AthFloater;
    public int[] PsyAthAbs => Psy8.AthAbs;

    public double[] PsyLowPass => Psy11.Lowpass;

    public PsyGlobal[] GlobalParams => Psy44.Global;
    public double[] GlobalMapping => Psy8.GlobalMapping;
    public AdjStereo[] StereoModes => Psy8.StereoModes;

    public IStaticCodeBook[][] FloorBooks => SharedFloors.FloorBooks;
    public Floor[] FloorParams => SharedFloors.Floor;
    public int[][] FloorMappings => Psy11.FloorMapping;

    public IMappingTemplate[] Maps => Residue8.MapRes_Uncoupled;
}
