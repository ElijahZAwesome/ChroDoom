namespace ChroDoom.Engine.WAD
{
    public struct Lump
    {
        public string Name;
        public int Offset;
        public int Size => Data.Length;
        public byte[] Data;
    }
}