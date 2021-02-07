namespace ChroDoom.Engine.WAD.Exceptions
{
    public class NotWadException : WadException
    {
        public NotWadException() : base(
            "The file is not any valid type of WAD or has been corrupted. Try re-downloading your wad?")
        {
        }

        public NotWadException(string? message) : base(message)
        {
        }
    }
}