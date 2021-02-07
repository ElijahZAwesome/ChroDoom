using System.IO;
using ChroDoom.Engine.WAD.Exceptions;
using ChroDoom.Helpers;

namespace ChroDoom.Engine.WAD
{
    public class Wad
    {
        public WadType Type;
        public Lump[] Directory;
        
        public static Wad LoadFromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Please provide a valid WAD file path");
            
            using MemoryStream stream = new(File.ReadAllBytes(path));
            using BinaryReader reader = new(stream);
            var wad = new Wad();

            var magic = reader.ReadFixedString(4);
            if (magic is not "IWAD" or "PWAD")
                throw new NotWadException();
            wad.Type = magic is "IWAD" ? WadType.Internal : WadType.Patch;

            wad.Directory = new Lump[reader.ReadUInt32()];
            var directoryOffset = reader.ReadUInt32();
            reader.BaseStream.Seek(directoryOffset, SeekOrigin.Begin);

            return wad;
        }
    }
}