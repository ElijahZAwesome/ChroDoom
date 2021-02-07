using System.IO;
using System.Text;

namespace ChroDoom.Helpers
{
    public static class BinaryReaderExtensions
    {
        public static string ReadFixedString(this BinaryReader reader, int count)
        {
            StringBuilder builder = new();
            for (var i = 0; i < count; i++)
                builder.Append(reader.ReadChar());

            return builder.ToString();
        }
    }
}