using S16 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo16;

namespace OggVorbisEncoder.Setup.Templates.Residue;

internal static class Residue16
{
    internal static readonly IStaticCodeBook C_HuffmanBook0Single = new S16.Coupled.Chapter0.Chapter0Single();
    internal static readonly IStaticBookBlock C_Block0 = new S16.Coupled.Blocks.Block0();

    internal static readonly IResidueTemplate[] C_Residue1 = {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook0Single,
            C_HuffmanBook0Single,
            C_Block0,
            C_Block0),
    };

    internal static readonly IStaticCodeBook C_HuffmanBook1Short = new S16.Coupled.Chapter1.Chapter1Short();
    internal static readonly IStaticCodeBook C_HuffmanBook1Long = new S16.Coupled.Chapter1.Chapter1Long();
    internal static readonly IStaticBookBlock C_Block1 = new S16.Coupled.Blocks.Block1();

    internal static readonly IResidueTemplate[] C_Residue2 = {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook1Short,
            C_HuffmanBook1Short,
            C_Block1,
            C_Block1),

        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook1Long,
            C_HuffmanBook1Long,
            C_Block1,
            C_Block1)
    };

    internal static readonly IStaticCodeBook C_HuffmanBook2Short = new S16.Coupled.Chapter2.Chapter2Short();
    internal static readonly IStaticCodeBook C_HuffmanBook2Long = new S16.Coupled.Chapter2.Chapter2Long();
    internal static readonly IStaticBookBlock C_Block2 = new S16.Coupled.Blocks.Block2();

    internal static readonly IResidueTemplate[] C_Residue3 = {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44High_Coupled,
            C_HuffmanBook2Short,
            C_HuffmanBook2Short,
            C_Block2,
            C_Block2),

        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44High_Coupled,
            C_HuffmanBook2Long,
            C_HuffmanBook2Long,
            C_Block2,
            C_Block2)
    };

    internal static readonly IMappingTemplate[] MapRes_Stereo =
    {
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue1),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue2),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue3),
    };

    internal static readonly IStaticCodeBook U_HuffmanBook0Single = new S16.Uncoupled.Chapter0.Chapter0Single();
    internal static readonly IStaticBookBlock U_Block0 = new S16.Uncoupled.Blocks.Block0();

    internal static readonly IResidueTemplate[] U_Residue0 = {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Low_Coupled,
            U_HuffmanBook0Single,
            U_HuffmanBook0Single,
            U_Block0,
            U_Block0)
    };

    internal static readonly IStaticCodeBook U_HuffmanBook1Short = new S16.Uncoupled.Chapter1.Chapter1Short();
    internal static readonly IStaticCodeBook U_HuffmanBook1Long = new S16.Uncoupled.Chapter1.Chapter1Long();
    internal static readonly IStaticBookBlock U_Block1 = new S16.Uncoupled.Blocks.Block1();

    internal static readonly IResidueTemplate[] U_Residue1 = {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Coupled,
            U_HuffmanBook1Short,
            U_HuffmanBook1Short,
            U_Block1,
            U_Block1),


        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Coupled,
            U_HuffmanBook1Long,
            U_HuffmanBook1Long,
            U_Block1,
            U_Block1)
    };

    internal static readonly IStaticCodeBook U_HuffmanBook2Short = new S16.Uncoupled.Chapter2.Chapter2Short();
    internal static readonly IStaticCodeBook U_HuffmanBook2Long = new S16.Uncoupled.Chapter2.Chapter2Long();
    internal static readonly IStaticBookBlock U_Block2 = new S16.Uncoupled.Blocks.Block2();

    internal static readonly IResidueTemplate[] U_Residue2 = {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44High_Uncoupled,
            U_HuffmanBook2Short,
            U_HuffmanBook2Short,
            U_Block2,
            U_Block2),

        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44High_Uncoupled,
            U_HuffmanBook2Long,
            U_HuffmanBook2Long,
            U_Block2,
            U_Block2)
    };

    internal static readonly IMappingTemplate[] MapRes_Uncoupled =
    {
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue0 ),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue1 ),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue2 )
    };
}
