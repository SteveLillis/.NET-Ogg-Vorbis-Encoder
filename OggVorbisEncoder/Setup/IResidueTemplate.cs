namespace OggVorbisEncoder.Setup;

public interface IResidueTemplate
{
    ResidueType ResidueType { get; }
    ResidueLimitType LimitType { get; }
    int Grouping { get; }
    ResidueEntry Residue { get; }
    IStaticCodeBook BookAux { get; }
    IStaticCodeBook BookAuxManaged { get; }
    IStaticBookBlock BooksBase { get; }
    IStaticBookBlock BooksBaseManaged { get; }
}
