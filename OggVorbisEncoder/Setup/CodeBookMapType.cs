namespace OggVorbisEncoder.Setup;

public enum CodeBookMapType : int
{
    None = 0,
    Implicit = 1, // implicitly populated values from map column
    Listed = 2 // listed arbitrary values
}
