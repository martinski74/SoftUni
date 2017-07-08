
public class InvalidSongNameException : InvalidSongExeption
{
    public override string Message => "Song name should be between 3 and 30 symbols.";
}

