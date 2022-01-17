using OggVorbisEncoder.Setup.Templates.Psyche;
using OggVorbisEncoder.Setup.Templates.Residue;

namespace OggVorbisEncoder.Setup.Templates;

public class Stereo16SetupDataTemplate : ISetupTemplate
{
    public int Mappings => SampleRateMapping.Length - 1;
    public double[] SampleRateMapping => Psy16.RateMap_Coupled;
    public double[] QualityMapping => Psy16.QualityMapping;
    public int CouplingRestriction => 2;
    public int SampleRateMinRestriction => 15000;
    public int SampleRateMaxRestriction => 19000;

    public int[] BlockSizeShort => Psy16.BlocksizeShort;
    public int[] BlockSizeLong => Psy16.BlocksizeLong;

    public Att3[] PsyToneMasterAtt => Psy16.VpToneMasterAtt;
    public int[] PsyTone0Decibel => Psy.ToneZeroDecibel;
    public int[] PsyToneDecibelSuppress => Psy.ToneSuppress;

    public AdjBlock[] PsyToneAdjImpulse => Psy16.VpToneMaskAdjOtherBlock;
    public AdjBlock[] PsyToneAdjLong => Psy16.VpToneMaskAdjOtherBlock;
    public AdjBlock[] PsyToneAdjOther => Psy16.VpToneMaskAdjOtherBlock;

    public NoiseGuard[] PsyNoiseGuards => Psy16.NoiseGuards;
    public Noise3[] PsyNoiseBiasImpulse => Psy16.NoiseBiasImpulse;
    public Noise3[] PsyNoiseBiasPadding => Psy16.NoiseBiasShort;
    public Noise3[] PsyNoiseBiasTrans => Psy16.NoiseBiasShort;
    public Noise3[] PsyNoiseBiasLong => Psy16.NoiseBias;
    public int[] PsyNoiseDecibelSuppress => Psy.NoiseSuppress;

    public CompandBlock[] PsyNoiseCompand => Psy8.Compand;
    public double[] PsyNoiseCompandShortMapping => Psy16.CompandMapping;
    public double[] PsyNoiseCompandLongMapping => Psy16.CompandMapping;

    public int[][] PsyNoiseNormalStart => new int[][] { Psy16.NoiseStart, Psy16.NoiseStart };
    public int[][] PsyNoiseNormalPartition => new int[][] { Psy16.NoisePart, Psy16.NoisePart };
    public double[] PsyNoiseNormalThreshold => Psy16.NoiseThresh;

    public int[] PsyAthFloat => Psy16.AthFloater;
    public int[] PsyAthAbs => Psy16.AthAbs;

    public double[] PsyLowPass => Psy16.Lowpass;

    public PsyGlobal[] GlobalParams => Psy44.Global;
    public double[] GlobalMapping => Psy16.GlobalMapping;
    public AdjStereo[] StereoModes => Psy16.StereoModes;

    public IStaticCodeBook[][] FloorBooks => SharedFloors.FloorBooks;
    public Floor[] FloorParams => SharedFloors.Floor;
    public int[][] FloorMappings => Psy16.FloorMapping;

    public IMappingTemplate[] Maps => Residue16.MapRes_Stereo;
}
