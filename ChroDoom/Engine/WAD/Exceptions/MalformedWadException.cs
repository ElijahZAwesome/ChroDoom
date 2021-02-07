namespace ChroDoom.Engine.WAD.Exceptions
{
    public class MalformedWadException : WadException
    {
        public MalformedWadException()
        {
        }

        public MalformedWadException(string? message) : base(message)
        {
        }
    }
}