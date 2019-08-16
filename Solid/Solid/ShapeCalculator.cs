using System.Linq;

namespace Solid
{
    public class ShapeCalculator
    {
        public double TotalAreas { get; private set; }
        public double TotalPerimeters { get; private set; }
        private IGeometricShape[] Shapes { get; set; }

        public ShapeCalculator(IGeometricShape[] shapes)
        {
            this.Shapes = shapes;
        }

        public void CalculateAreas() =>
            Shapes.Sum(s => TotalAreas += s.Area());

        public void CalculatePerimeters() =>
            Shapes.Sum(s => TotalPerimeters += s.Perimeter());

    }
}
