using System.Linq;
using System.Collections.Generic;

namespace Solid
{
    public class AreaOperations
    {
        public static double SumAreas(IEnumerable<IGeometricShape> shapes) =>
            shapes.Sum(s => s.Area());

    }
}
