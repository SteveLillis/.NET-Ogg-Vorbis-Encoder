using System;
using System.Collections.Generic;
using System.Text;

namespace OggVorbisEncoder.Setup.Templates.Residue;

internal class Shared
{
    internal static readonly Mapping[] MapNominal_Coupled =
    {
        new Mapping(1, new[] {0, 0}, new[] {0}, new[] {0}, 1, new[] {0}, new[] {1}),
        new Mapping(1, new[] {0, 0}, new[] {1}, new[] {1}, 1, new[] {0}, new[] {1})
    };

    internal static readonly Mapping[] MapNominal_Uncoupled =
    {
        new Mapping(1, new[] {0, 0, 0, 0, 0, 0}, new[] {0}, new[] {0}, 0, new[] {0}, new[] {0}),
        new Mapping(1, new[] {0, 0, 0, 0, 0, 0}, new[] {1}, new[] {1}, 0, new[] {0}, new[] {0})
    };

    internal static readonly ResidueEntry Residue44Low_Coupled = new ResidueEntry(
        0, -1, -1, 9, -1, -1,
        new[] { 0 }, new[] { -1 },
        new[] { 0, 1, 2, 2, 4, 8, 16, 32 },
        new[] { 0, 0, 0, 999, 4, 8, 16, 32 },
        ResidueType.Zero);

    internal static readonly ResidueEntry Residue44Medium_Coupled = new ResidueEntry(
        0, -1, -1, 10, -1, -1,
        new[] { 0 }, new[] { -1 },
        new[] { 0, 1, 1, 2, 2, 4, 8, 16, 32 },
        new[] { 0, 0, 999, 0, 999, 4, 8, 16, 32 },
        ResidueType.Zero);

    internal static readonly ResidueEntry Residue44High_Coupled = new ResidueEntry(
        0, -1, -1, 9, -1, -1,
        new[] { 0 }, new[] { -1 },
        new[] { 0, 1, 2, 2, 4, 8, 16, 32 },
        new[] { 0, 0, 0, 999, 4, 8, 16, 32 },
        ResidueType.Zero);


    internal static readonly ResidueEntry Residue44Low_Uncoupled = new ResidueEntry(
        0, -1, -1, 8, -1, -1,
        new[] { 0 }, new[] { -1 },
        new[] { 0, 1, 1, 2, 2, 4, 28 },
        new[] { -1, 25, -1, 45, -1, -1, -1 },
        ResidueType.Zero);

    internal static readonly ResidueEntry Residue44Medium_Uncoupled = new ResidueEntry(
        0, -1, -1, 10, -1, -1,
        new[] { 0 }, new[] { -1 },
        new[] { 0, 1, 1, 2, 2, 4, 4, 16, 60 },
        new[] { -1, 30, -1, 50, -1, 80, -1, -1, -1 },
        ResidueType.Zero);

    internal static readonly ResidueEntry Residue44High_Uncoupled = new ResidueEntry(
        0, -1, -1, 10, -1, -1,
        new[] { 0 }, new[] { -1 },
        new[] { 0, 1, 2, 4, 8, 16, 32, 71, 157 },
        new[] { -1, -1, -1, -1, -1, -1, -1, -1, -1 },
        ResidueType.Zero);
}
