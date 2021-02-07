namespace ChroDoom.Engine.WAD.Exceptions
{
    public class MalformedLumpException : WadException
    {
        public MalformedLumpException()
        {
        }

        public MalformedLumpException(string? message) : base(message)
        {
        }
    }
}