using Blocks = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Blocks;

using CN1 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.ChapterNeg1;
using C0 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter0;
using C1 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter1;
using C2 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter2;
using C3 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter3;
using C4 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter4;
using C5 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter5;
using C6 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter6;
using C7 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter7;
using C8 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter8;
using C9 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Uncoupled.Chapter9;

namespace OggVorbisEncoder.Setup.Templates.Residue;

internal static partial class Residue44
{

    internal static readonly IStaticCodeBook U_HuffmanBookNegOneShort = new CN1.ChapterNeg1Short();
    internal static readonly IStaticCodeBook U_HuffmanBookNegOneLong = new CN1.ChapterNeg1Long();
    internal static readonly IStaticBookBlock U_BlockNeg1 = new Blocks.BlockNeg1();

    internal static readonly IResidueTemplate[] U_ResidueNegative1 =
    {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Low_Uncoupled,
            U_HuffmanBookNegOneShort,
            U_HuffmanBookNegOneShort,
            U_BlockNeg1,
            U_BlockNeg1),
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Low_Uncoupled,
            U_HuffmanBookNegOneLong,
            U_HuffmanBookNegOneLong,
            U_BlockNeg1,
            U_BlockNeg1)
    };

    internal static readonly IStaticCodeBook U_HuffmanBook0Short = new C0.Chapter0Short();
    internal static readonly IStaticCodeBook U_HuffmanBook0Long = new C0.Chapter0Long();
    internal static readonly IStaticBookBlock U_Block0 = new Blocks.Block0();

    internal static readonly IResidueTemplate[] U_Residue0 =
    {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44Low_Uncoupled,
            U_HuffmanBook0Short,
            U_HuffmanBook0Short,
            U_Block0,
            U_Block0),
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Low_Uncoupled,
            U_HuffmanBook0Long,
            U_HuffmanBook0Long,
            U_Block0,
            U_Block0)
    };

    internal static readonly IStaticCodeBook U_HuffmanBook1Short = new C1.Chapter1Short();
    internal static readonly IStaticCodeBook U_HuffmanBook1Long = new C1.Chapter1Long();
    internal static readonly IStaticBookBlock U_Block1 = new Blocks.Block1();

    internal static readonly IResidueTemplate[] U_Residue1 =
    {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44Low_Uncoupled,
            U_HuffmanBook1Short,
            U_HuffmanBook1Short,
            U_Block1,
            U_Block1),
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Low_Uncoupled,
            U_HuffmanBook1Long,
            U_HuffmanBook1Long,
            U_Block1,
            U_Block1)
    };

    internal static readonly IStaticCodeBook U_HuffmanBook2Short = new C2.Chapter2Short();
    internal static readonly IStaticCodeBook U_HuffmanBook2Long = new C2.Chapter2Long();
    internal static readonly IStaticBookBlock U_Block2 = new Blocks.Block2();

    internal static readonly IResidueTemplate[] U_Residue2 =
    {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44Medium_Uncoupled,
            U_HuffmanBook2Short,
            U_HuffmanBook2Short,
            U_Block2,
            U_Block2),
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Uncoupled,
            U_HuffmanBook2Long,
            U_HuffmanBook2Long,
            U_Block2,
            U_Block2)
    };

    internal static readonly IStaticCodeBook U_HuffmanBook3Short = new C3.Chapter3Short();
    internal static readonly IStaticCodeBook U_HuffmanBook3Long = new C3.Chapter3Long();
    internal static readonly IStaticBookBlock U_Block3 = new Blocks.Block3();

    internal static readonly IResidueTemplate[] U_Residue3 =
    {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass,
            16,
            Shared.Residue44Medium_Uncoupled,
            U_HuffmanBook3Short,
            U_HuffmanBook3Short,
            U_Block3,
            U_Block3),
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass,
            32,
            Shared.Residue44Medium_Uncoupled,
            U_HuffmanBook3Long,
            U_HuffmanBook3Long,
            U_Block3,
            U_Block3)
    };

    internal static readonly IStaticCodeBook U_HuffmanBook4Short = new C4.Chapter4Short();
    internal static readonly IStaticCodeBook U_HuffmanBook4Long = new C4.Chapter4Long();
    internal static readonly IStaticBookBlock U_Block4 = new Blocks.Block4();

    internal static readonly IResidueTemplate[] U_Residue4 =
    {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass,
            16,
            Shared.Residue44Medium_Uncoupled,
            U_HuffmanBook4Short,
            U_HuffmanBook4Short,
            U_Block4,
            U_Block4),
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass,
            32,
            Shared.Residue44Medium_Uncoupled,
            U_HuffmanBook4Long,
            U_HuffmanBook4Long,
            U_Block4,
            U_Block4)
    };

    internal static readonly IStaticCodeBook U_HuffmanBook5Short = new C5.Chapter5Short();
    internal static readonly IStaticCodeBook U_HuffmanBook5Long = new C5.Chapter5Long();
    internal static readonly IStaticBookBlock U_Block5 = new Blocks.Block5();

    internal static readonly IResidueTemplate[] U_Residue5 =
    {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass,
            16,
            Shared.Residue44Medium_Uncoupled,
            U_HuffmanBook5Short,
            U_HuffmanBook5Short,
            U_Block5,
            U_Block5),
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass,
            32,
            Shared.Residue44Medium_Uncoupled,
            U_HuffmanBook5Long,
            U_HuffmanBook5Long,
            U_Block5,
            U_Block5)
    };

    internal static readonly IStaticCodeBook U_HuffmanBook6Short = new C6.Chapter6Short();
    internal static readonly IStaticCodeBook U_HuffmanBook6Long = new C6.Chapter6Long();
    internal static readonly IStaticBookBlock U_Block6 = new Blocks.Block6();

    internal static readonly IResidueTemplate[] U_Residue6 =
    {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass,
            16,
            Shared.Residue44High_Uncoupled,
            U_HuffmanBook6Short,
            U_HuffmanBook6Short,
            U_Block6,
            U_Block6),
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass,
            32,
            Shared.Residue44High_Uncoupled,
            U_HuffmanBook6Long,
            U_HuffmanBook6Long,
            U_Block6,
            U_Block6)
    };

    internal static readonly IStaticCodeBook U_HuffmanBook7Short = new C7.Chapter7Short();
    internal static readonly IStaticCodeBook U_HuffmanBook7Long = new C7.Chapter7Long();
    internal static readonly IStaticBookBlock U_Block7 = new Blocks.Block7();

    internal static readonly IResidueTemplate[] U_Residue7 =
    {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44High_Uncoupled,
            U_HuffmanBook7Short,
            U_HuffmanBook7Short,
            U_Block7,
            U_Block7),
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44High_Uncoupled,
            U_HuffmanBook7Long,
            U_HuffmanBook7Long,
            U_Block7,
            U_Block7)
    };

    internal static readonly IStaticCodeBook U_HuffmanBook8Short = new C8.Chapter8Short();
    internal static readonly IStaticCodeBook U_HuffmanBook8Long = new C8.Chapter8Long();
    internal static readonly IStaticBookBlock U_Block8 = new Blocks.Block8();

    internal static readonly IResidueTemplate[] U_Residue8 =
    {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44High_Uncoupled,
            U_HuffmanBook8Short,
            U_HuffmanBook8Short,
            U_Block8,
            U_Block8),
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44High_Uncoupled,
            U_HuffmanBook8Long,
            U_HuffmanBook8Long,
            U_Block8,
            U_Block8)
    };

    internal static readonly IStaticCodeBook U_HuffmanBook9Short = new C9.Chapter9Short();
    internal static readonly IStaticCodeBook U_HuffmanBook9Long = new C9.Chapter9Long();
    internal static readonly IStaticBookBlock U_Block9 = new Blocks.Block9();

    internal static readonly IResidueTemplate[] U_Residue9 =
    {
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44High_Uncoupled,
            U_HuffmanBook9Short,
            U_HuffmanBook9Short,
            U_Block9,
            U_Block9),
        new ResidueTemplate(
            ResidueType.One,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44High_Uncoupled,
            U_HuffmanBook9Long,
            U_HuffmanBook9Long,
            U_Block9,
            U_Block9)
    };

    public static readonly IMappingTemplate[] MapRes_Uncoupled =
    {
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_ResidueNegative1),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue0),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue1),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue2),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue3),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue4),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue5),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue6),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue7),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue8),
        new MappingTemplate(Shared.MapNominal_Uncoupled, U_Residue9)
    };
}
