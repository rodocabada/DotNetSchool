using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    public class ShapeCalculator
    {
        public double TotalAreas { get; private set; }
        public double TotalPerimeters { get; private set; }

        public ShapeCalculator(IGeometricShape[] shapes)
        {

        }

        public void CalculateAreas(IEnumerable<IGeometricShape> shapes) =>
            shapes.Sum(s => TotalAreas += s.Area());

        public void CalculatePerimeters(IEnumerable<IGeometricShape> shapes) =>
            shapes.Sum(s => TotalPerimeters += s.Perimeter());

    }
}
