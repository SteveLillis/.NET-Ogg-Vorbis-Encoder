using S8 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo8;

namespace OggVorbisEncoder.Setup.Templates.Residue;

internal static class Residue8
{
    private static readonly IStaticCodeBook C_HuffmanBook0Single = new S8.Coupled.Chapter0.Chapter0Single();
    private static readonly IStaticBookBlock C_Block0 = new S8.Coupled.Blocks.Block0();

    internal static readonly IResidueTemplate[] C_Residue0 = {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook0Single,
            C_HuffmanBook0Single,
            C_Block0,
            C_Block0),
    };

    private static readonly IStaticCodeBook C_HuffmanBook1Single = new S8.Coupled.Chapter1.Chapter1Single();
    private static readonly IStaticBookBlock C_Block1 = new S8.Coupled.Blocks.Block1();

    internal static readonly IResidueTemplate[] C_Residue1 = {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook1Single,
            C_HuffmanBook1Single,
            C_Block1,
            C_Block1),
    };

    internal static readonly IMappingTemplate[] MapRes_Coupled =
    {
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue0),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue1)
    };

    private static readonly IStaticCodeBook U_HuffmanBook0Single = new S8.Uncoupled.Chapter0.Chapter0Single();
    private static readonly IStaticBookBlock U_Block0 = new S8.Uncoupled.Blocks.Block0();

    internal static readonly IResidueTemplate[] U_Residue0 = {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Uncoupled,
            U_HuffmanBook0Single,
            U_HuffmanBook0Single,
            U_Block0,
            U_Block0)
    };

    private static readonly IStaticCodeBook U_HuffmanBook1Single = new S8.Uncoupled.Chapter1.Chapter1Single();
    private static readonly IStaticBookBlock U_Block1 = new S8.Uncoupled.Blocks.Block1();

    internal static readonly IResidueTemplate[] U_Residue1 = {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Uncoupled,
            U_HuffmanBook1Single,
            U_HuffmanBook1Single,
            U_Block1,
            U_Block1)
    };

    internal static readonly IMappingTemplate[] MapRes_Uncoupled =
    {
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue0 ),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue1 )
    };
}
