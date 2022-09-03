using OggVorbisEncoder.Setup;
using OggVorbisEncoder.Setup.Templates;
using System;
using System.Collections.Generic;

namespace OggVorbisEncoder;

public class EncodeSetup
{
    private static IEnumerable<ISetupTemplate> CreateTemplates()
    {
        return new ISetupTemplate[]
        {
            new Stereo44SetupDataTemplate(),
            new Uncoupled44SetupDataTemplate(),
            new Stereo32SetupDataTemplate(),
            new Uncoupled32SetupDataTemplate(),
            new Stereo22SetupDataTemplate(),
            new Uncoupled22SetupDataTemplate(),
            new Stereo16SetupDataTemplate(),
            new Uncoupled16SetupDataTemplate(),
            new Stereo11SetupDataTemplate(),
            new Uncoupled11SetupDataTemplate(),
            new Stereo8SetupDataTemplate(),
            new Uncoupled8SetupDataTemplate(),
            new StereoXSetupDataTemplate(),
            new UncoupledXSetupDataTemplate(),
            new StereoXXSetupDataTemplate(),
            new UncoupledXXSetupDataTemplate()
        };
    }


    private static readonly IEnumerable<ISetupTemplate> SetupTemplates = CreateTemplates();

    public EncodeSetup(ISetupTemplate template, double baseSetting)
    {
        Template = template;
        BaseSetting = baseSetting;

        var iS = (int)BaseSetting;
        var ds = BaseSetting - iS;

        LowPassKilohertz = template.PsyLowPass[iS] * (1 - ds) + template.PsyLowPass[iS + 1] * ds;

        AthFloatingDecibel = template.PsyAthFloat[iS] * (1 - ds) + template.PsyAthFloat[iS + 1] * ds;

        AthAbsoluteDecibel = template.PsyAthAbs[iS] * (1 - ds) + template.PsyAthAbs[iS + 1] * ds;

        AmplitudeTrackDbPerSec = -6;

        // too low/high an ATH floater is nonsensical, but doesn't break anything 
        if (AthFloatingDecibel > -80)
            AthFloatingDecibel = -80;

        if (AthFloatingDecibel < -200)
            AthFloatingDecibel = -200;

        if (AmplitudeTrackDbPerSec > 0)
            AmplitudeTrackDbPerSec = 0;

        if (AmplitudeTrackDbPerSec < -99999)
            AmplitudeTrackDbPerSec = -99999;
    }

    public ISetupTemplate Template { get; }
    public double BaseSetting { get; }
    public double LowPassKilohertz { get; }
    public double AthFloatingDecibel { get; }
    public double AthAbsoluteDecibel { get; }
    public double AmplitudeTrackDbPerSec { get; }

    public static EncodeSetup GetBestMatch(
        int channels,
        int sampleRate,
        float quality)
    {
        foreach (var template in SetupTemplates)
        {
            if ((template.CouplingRestriction != -1)
                && (template.CouplingRestriction != channels))
                continue;

            if ((sampleRate < template.SampleRateMinRestriction)
                || (sampleRate > template.SampleRateMaxRestriction))
                continue;

            var map = template.QualityMapping;

            // the template matches.  Does the requested quality mode fall within this template's modes? 
            if ((quality < map[0])
                || (quality > map[template.Mappings]))
                continue;

            int j;
            for (j = 0; j < template.Mappings; ++j)
                if ((quality >= map[j]) && (quality < map[j + 1]))
                    break;

            // an all-points match
            double baseSetting;
            if (j == template.Mappings)
            {
                baseSetting = j - .001;
            }
            else
            {
                var low = map[j];
                var high = map[j + 1];
                var del = (quality - low) / (high - low);
                baseSetting = j + del;
            }

            return new EncodeSetup(template, baseSetting);
        }

        throw new InvalidOperationException("No matching template found");
    }
}
