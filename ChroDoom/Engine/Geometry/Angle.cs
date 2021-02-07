using System;
using System.Numerics;

// ReSharper disable PossibleLossOfFraction

#nullable enable
namespace ChroDoom.Engine.Geometry
{
    public struct Angle
    {
        private float _degrees;

        public float Degrees
        {
            get => _degrees;
            set => _degrees = value - 360 * (int) Math.Floor(value / 360);
        }

        public float Signed => Degrees > 180 ? Degrees - 360 : Degrees;

        public Vector2 Vector
        {
            get
            {
                var rad = Degrees * Math.PI / 180;
                return new Vector2((float) Math.Cos(rad), (float) Math.Sin(rad));
            }
        }

        public float Radian => (float) (Degrees * Math.PI / 180);

        public Angle(Angle other)
        {
            _degrees = other.Degrees;
        }

        public Angle(float degrees)
        {
            _degrees = degrees;
            Degrees = _degrees;
        }

        public Angle(double degrees)
        {
            _degrees = (float) degrees;
            Degrees = _degrees;
        }

        public static Angle FromRadians(float radians)
        {
            return new(radians * 180 / Math.PI);
        }

        public float Cos()
        {
            return (float) Math.Cos(Radian);
        }

        public float Sin()
        {
            return (float) Math.Sin(Radian);
        }

        public float Tan()
        {
            return (float) Math.Tan(Radian);
        }

        public static Angle operator +(Angle a) => a;
        public static Angle operator -(Angle a) => new(360 - a.Degrees);
        public static Angle operator +(Angle a, Angle b) => new(a.Degrees + b.Degrees);
        public static Angle operator +(Angle a, float b) => new(a.Degrees + b);
        public static Angle operator -(Angle a, Angle b) => new(a.Degrees - b.Degrees);
        public static Angle operator -(Angle a, float b) => new(a.Degrees - b);
        public static Angle operator *(Angle a, Angle b) => new(a.Degrees * b.Degrees);
        public static Angle operator *(Angle a, float b) => new(a.Degrees * b);
        public static Angle operator /(Angle a, Angle b) => new(a.Degrees / b.Degrees);
        public static Angle operator /(Angle a, float b) => new(a.Degrees / b);

        public static bool operator >(Angle a, Angle b) => a.Degrees > b.Degrees;
        public static bool operator >(Angle a, float b) => a.Degrees > b;
        public static bool operator <(Angle a, Angle b) => a.Degrees < b.Degrees;
        public static bool operator <(Angle a, float b) => a.Degrees < b;
        public static bool operator >=(Angle a, Angle b) => a.Degrees >= b.Degrees;
        public static bool operator >=(Angle a, float b) => a.Degrees >= b;
        public static bool operator <=(Angle a, Angle b) => a.Degrees <= b.Degrees;
        public static bool operator <=(Angle a, float b) => a.Degrees <= b;

        public override bool Equals(object? obj)
        {
            if (!(obj is Angle) || !(obj is float))
                return false;

            var comp = (obj as Angle?)?.Degrees ?? (float) obj;
            return comp == Degrees;
        }

        public override string ToString() => Degrees.ToString();
    }
}