using System.Numerics;
using ChroDoom.Engine.Geometry;

namespace ChroDoom.Engine
{
    public class Player
    {
        public int Id = 0;
        public Vector3 Position = Vector3.Zero;
        public int EyeHeight = 41;
        public Angle Angle;

        public Sector CurrentSector;
    }
}