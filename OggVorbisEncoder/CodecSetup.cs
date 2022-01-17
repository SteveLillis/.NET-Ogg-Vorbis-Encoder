using System.Collections.Generic;
using OggVorbisEncoder.Setup;

namespace OggVorbisEncoder;

public class CodecSetup
{
    public CodecSetup(EncodeSetup encodeSetup)
    {
        EncodeSetup = encodeSetup;
    }

    public EncodeSetup EncodeSetup { get; }

    public int[] BlockSizes { get; } = new int[2];

    public CodeBook[] FullBooks { get; set; }
    public IList<IStaticCodeBook> BookParams { get; } = new List<IStaticCodeBook>();
    public IList<Mode> ModeParams { get; } = new List<Mode>();
    public IList<Mapping> MapParams { get; } = new List<Mapping>();
    public IList<Floor> FloorParams { get; } = new List<Floor>();
    public IList<ResidueEntry> ResidueParams { get; } = new List<ResidueEntry>();
    public IList<PsyInfo> PsyParams { get; } = new List<PsyInfo>();
    public PsyGlobal PsyGlobalParam { get; set; }
}
