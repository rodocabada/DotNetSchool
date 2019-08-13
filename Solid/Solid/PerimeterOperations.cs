using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    public class PerimeterOperations
    {
        public static double SumPerimeters(IEnumerable<IGeometricShape> shapes)
        {
            double perimeter = 0d;

            foreach(var shape in shapes)
            {
                perimeter += shape.Perimeter();
            }

            return perimeter;
        }

        public static double SumPerimeters2(IEnumerable<IGeometricShape> shapes) =>
            shapes.Sum(s => s.Perimeter());

    }
}
