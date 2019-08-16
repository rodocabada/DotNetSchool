namespace Solid
{
    public class Rectangle : IGeometricShape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double Area() => Height * Width;

        public double Perimeter() => 2 * Height + 2 * Width;
    }
}
