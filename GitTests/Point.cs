using static System.Math;

namespace GitTests
{
    public class Point
    {
        public int x { get; }
        public int y { get; }

        public double Distance(Point other)
            => Sqrt(Pow(this.x - other.x, 2) + Pow(this.y - other.y, 2));
    }
}