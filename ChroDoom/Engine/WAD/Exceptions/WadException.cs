using System;

namespace ChroDoom.Engine.WAD.Exceptions
{
    public class WadException : Exception
    {
        public WadException()
        {
        }

        public WadException(string? message) : base(message)
        {
        }
    }
}