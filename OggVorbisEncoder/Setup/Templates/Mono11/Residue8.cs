using OggVorbisEncoder.Setup.Templates.Mono11.BookBlocks.Chapter0;
using OggVorbisEncoder.Setup.Templates.Mono11.BookBlocks.Chapter1;
using OggVorbisEncoder.Setup.Templates.Mono11.HuffmanBooks;

namespace OggVorbisEncoder.Setup.Templates.Mono11
{
    public static class Residue8
    {
        private static readonly Mapping[] MapNominalUncoupled =
        {
            new Mapping(new[] {0,0,0,0,0,0}, new[] {0}, new[] {0}, new[] {0}, new[] {0}),
            new Mapping(new[] {0,0,0,0,0,0}, new[] {1}, new[] {1}, new[] {0}, new[] {0})
        };

        private static readonly Residue Residue44LowUncoupled = new Residue(
            0, -1, -1, 8, -1, -1,
            new[] { 0 }, new[] { -1 },
            new[] { 0, 1, 1, 2, 2, 4, 28 },
            new[] { -1, 25, -1, 45, -1, -1, -1 },
            ResidueType.Zero
        );

        private static readonly Residue Residue44MidUncoupled = new Residue(
            0, -1, -1, 10, -1, -1,
            new[] { 0 }, new[] { -1 },
            new[] { 0, 1, 1, 2, 2, 4, 4, 16, 60 },
            new[] { -1, 30, -1, 50, -1, 80, -1, -1, -1 },
            ResidueType.Zero
        );


        private static readonly IStaticCodeBook HuffmanBook0Single = new Chapter0Single();
        private static readonly IStaticBookBlock Block0 = new Block0();

        private static readonly IResidueTemplate[] Residue0 =
        {
            new ResidueTemplate(
                ResidueType.One,
                ResidueLimitType.LowPass,
                32,
                Residue44LowUncoupled,
                HuffmanBook0Single,
                HuffmanBook0Single,
                Block0,
                Block0)
        };

        private static readonly IStaticCodeBook HuffmanBook1Single = new Chapter1Single();
        private static readonly IStaticBookBlock Block1 = new Block1();

        private static readonly IResidueTemplate[] Residue1 =
        {
            new ResidueTemplate(
                ResidueType.One,
                ResidueLimitType.LowPass,
                32,
                Residue44MidUncoupled,
                HuffmanBook1Single,
                HuffmanBook1Single,
                Block1,
                Block1)
        };

        public static readonly IMappingTemplate[] MapRes8Mono =
        {
            new MappingTemplate(MapNominalUncoupled, Residue0),
            new MappingTemplate(MapNominalUncoupled, Residue1),
        };
    }
}
