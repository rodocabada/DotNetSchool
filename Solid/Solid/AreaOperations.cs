using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    public class AreaOperations
    {
        public static double SumAreas(IEnumerable<IGeometricShape> shapes)
        {
            var area = 0d;

            foreach(var shape in shapes)
            {
                area += shape.Area();
            }

            return area;
        }

        public static double SumAreas2(IEnumerable<IGeometricShape> shapes) =>
            shapes.Sum(s => s.Area());

    }
}
