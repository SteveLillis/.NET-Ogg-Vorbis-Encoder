using Blocks = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Blocks;

using CN1 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ChapterNeg1;
using C0 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter0;
using C1 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter1;
using C2 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter2;
using C3 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter3;
using C4 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter4;
using C5 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter5;
using C6 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter6;
using C7 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter7;
using C8 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter8;
using C9 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.Chapter9;

using MCN1 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapterNeg1;
using MC0 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapter0;
using MC1 = OggVorbisEncoder.Setup.Templates.BookBlocks.Stereo44.Coupled.ManagedChapter1;

namespace OggVorbisEncoder.Setup.Templates.Residue;

internal static partial class Residue44
{

    internal static readonly IStaticCodeBook C_HuffmanBookNegOneShort = new CN1.ChapterNeg1Short();
    internal static readonly IStaticCodeBook C_HuffmanBookNegOneShortManaged = new MCN1.ManagedChapterNeg1Short();
    internal static readonly IStaticCodeBook C_HuffmanBookNegOneLong = new CN1.ChapterNeg1Long();
    internal static readonly IStaticCodeBook C_HuffmanBookNegOneLongManaged = new MCN1.ManagedChapterNeg1Long();
    internal static readonly IStaticBookBlock C_BlockNeg1 = new Blocks.BlockNeg1();
    internal static readonly IStaticBookBlock C_BlockNeg1Managed = new Blocks.ManagedBlockNeg1();

    internal static readonly IResidueTemplate[] C_ResidueNegative1 =
    {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Low_Coupled,
            C_HuffmanBookNegOneShort,
            C_HuffmanBookNegOneShortManaged,
            C_BlockNeg1,
            C_BlockNeg1Managed),
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Low_Coupled,
            C_HuffmanBookNegOneLong,
            C_HuffmanBookNegOneLongManaged,
            C_BlockNeg1,
            C_BlockNeg1Managed)
    };

    internal static readonly IStaticCodeBook C_HuffmanBook0Short = new C0.Chapter0Short();
    internal static readonly IStaticCodeBook C_HuffmanBook0ShortManaged = new MC0.ManagedChapter0Short();
    internal static readonly IStaticCodeBook C_HuffmanBook0Long = new C0.Chapter0Long();
    internal static readonly IStaticCodeBook C_HuffmanBook0LongManaged = new MC0.ManagedChapter0Long();
    internal static readonly IStaticBookBlock C_Block0 = new Blocks.Block0();
    internal static readonly IStaticBookBlock C_Block0Managed = new Blocks.ManagedBlock0();

    internal static readonly IResidueTemplate[] C_Residue0 =
    {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44Low_Coupled,
            C_HuffmanBook0Short,
            C_HuffmanBook0ShortManaged,
            C_Block0,
            C_Block0Managed),
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Low_Coupled,
            C_HuffmanBook0Long,
            C_HuffmanBook0LongManaged,
            C_Block0,
            C_Block0Managed)
    };

    internal static readonly IStaticCodeBook C_HuffmanBook1Short = new C1.Chapter1Short();
    internal static readonly IStaticCodeBook C_HuffmanBook1ShortManaged = new MC1.ManagedChapter1Short();
    internal static readonly IStaticCodeBook C_HuffmanBook1Long = new C1.Chapter1Long();
    internal static readonly IStaticCodeBook C_HuffmanBook1LongManaged = new MC1.ManagedChapter1Long();
    internal static readonly IStaticBookBlock C_Block1 = new Blocks.Block1();
    internal static readonly IStaticBookBlock C_Block1Managed = new Blocks.ManagedBlock1();

    internal static readonly IResidueTemplate[] C_Residue1 =
    {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44Low_Coupled,
            C_HuffmanBook1Short,
            C_HuffmanBook1ShortManaged,
            C_Block1,
            C_Block1Managed),
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Low_Coupled,
            C_HuffmanBook1Long,
            C_HuffmanBook1LongManaged,
            C_Block1,
            C_Block1Managed)
    };

    internal static readonly IStaticCodeBook C_HuffmanBook2Short = new C2.Chapter2Short();
    internal static readonly IStaticCodeBook C_HuffmanBook2Long = new C2.Chapter2Long();
    internal static readonly IStaticBookBlock C_Block2 = new Blocks.Block2();


    internal static readonly IResidueTemplate[] C_Residue2 =
    {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook2Short,
            C_HuffmanBook2Short,
            C_Block2,
            C_Block2),
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook2Long,
            C_HuffmanBook2Long,
            C_Block2,
            C_Block2)
    };

    internal static readonly IStaticCodeBook C_HuffmanBook3Short = new C3.Chapter3Short();
    internal static readonly IStaticCodeBook C_HuffmanBook3Long = new C3.Chapter3Long();
    internal static readonly IStaticBookBlock C_Block3 = new Blocks.Block3();

    internal static readonly IResidueTemplate[] C_Residue3 =
    {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook3Short,
            C_HuffmanBook3Short,
            C_Block3,
            C_Block3),
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook3Long,
            C_HuffmanBook3Long,
            C_Block3,
            C_Block3)
    };

    internal static readonly IStaticCodeBook C_HuffmanBook4Short = new C4.Chapter4Short();
    internal static readonly IStaticCodeBook C_HuffmanBook4Long = new C4.Chapter4Long();
    internal static readonly IStaticBookBlock C_Block4 = new Blocks.Block4();

    internal static readonly IResidueTemplate[] C_Residue4 =
    {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook4Short,
            C_HuffmanBook4Short,
            C_Block4,
            C_Block4),
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook4Long,
            C_HuffmanBook4Long,
            C_Block4,
            C_Block4)
    };

    internal static readonly IStaticCodeBook C_HuffmanBook5Short = new C5.Chapter5Short();
    internal static readonly IStaticCodeBook C_HuffmanBook5Long = new C5.Chapter5Long();
    internal static readonly IStaticBookBlock C_Block5 = new Blocks.Block5();

    internal static readonly IResidueTemplate[] C_Residue5 =
    {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook5Short,
            C_HuffmanBook5Short,
            C_Block5,
            C_Block5),
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44Medium_Coupled,
            C_HuffmanBook5Long,
            C_HuffmanBook5Long,
            C_Block5,
            C_Block5)
    };

    internal static readonly IStaticCodeBook C_HuffmanBook6Short = new C6.Chapter6Short();
    internal static readonly IStaticCodeBook C_HuffmanBook6Long = new C6.Chapter6Long();
    internal static readonly IStaticBookBlock C_Block6 = new Blocks.Block6();

    internal static readonly IResidueTemplate[] C_Residue6 =
    {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44High_Coupled,
            C_HuffmanBook6Short,
            C_HuffmanBook6Short,
            C_Block6,
            C_Block6),
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44High_Coupled,
            C_HuffmanBook6Long,
            C_HuffmanBook6Long,
            C_Block6,
            C_Block6)
    };

    internal static readonly IStaticCodeBook C_HuffmanBook7Short = new C7.Chapter7Short();
    internal static readonly IStaticCodeBook C_HuffmanBook7Long = new C7.Chapter7Long();
    internal static readonly IStaticBookBlock C_Block7 = new Blocks.Block7();

    internal static readonly IResidueTemplate[] C_Residue7 =
    {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44High_Coupled,
            C_HuffmanBook7Short,
            C_HuffmanBook7Short,
            C_Block7,
            C_Block7),
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44High_Coupled,
            C_HuffmanBook7Long,
            C_HuffmanBook7Long,
            C_Block7,
            C_Block7)
    };

    internal static readonly IStaticCodeBook C_HuffmanBook8Short = new C8.Chapter8Short();
    internal static readonly IStaticCodeBook C_HuffmanBook8Long = new C8.Chapter8Long();
    internal static readonly IStaticBookBlock C_Block8 = new Blocks.Block8();

    internal static readonly IResidueTemplate[] C_Residue8 =
    {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44High_Coupled,
            C_HuffmanBook8Short,
            C_HuffmanBook8Short,
            C_Block8,
            C_Block8),
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44High_Coupled,
            C_HuffmanBook8Long,
            C_HuffmanBook8Long,
            C_Block8,
            C_Block8)
    };

    internal static readonly IStaticCodeBook C_HuffmanBook9Short = new C9.Chapter9Short();
    internal static readonly IStaticCodeBook C_HuffmanBook9Long = new C9.Chapter9Long();
    internal static readonly IStaticBookBlock C_Block9 = new Blocks.Block9();

    internal static readonly IResidueTemplate[] C_Residue9 =
    {
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 16,
            Shared.Residue44High_Coupled,
            C_HuffmanBook9Short,
            C_HuffmanBook9Short,
            C_Block9,
            C_Block9),
        new ResidueTemplate(
            ResidueType.Two,
            ResidueLimitType.LowPass, 32,
            Shared.Residue44High_Coupled,
            C_HuffmanBook9Long,
            C_HuffmanBook9Long,
            C_Block9,
            C_Block9)
    };

    public static readonly IMappingTemplate[] MapRes_Coupled =
    {
        new MappingTemplate(Shared.MapNominal_Coupled, C_ResidueNegative1),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue0),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue1),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue2),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue3),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue4),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue5),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue6),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue7),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue8),
        new MappingTemplate(Shared.MapNominal_Coupled, C_Residue9)
    };
}
