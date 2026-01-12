using System.Numerics;

namespace VectorTest
{
    public static class VectorMaking
    {
        public static Vector2 CreateVector(double length, double degrees)
        {
            double radians = degrees * Math.PI / 180.0;

            float dx = (float)(length * Math.Cos(radians));
            float dy = (float)(length * Math.Sin(radians));

            return new Vector2(dx, dy);
        }
    }
}