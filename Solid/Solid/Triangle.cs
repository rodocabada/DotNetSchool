using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    public class Triangle : IGeometricShape
    {
        public double SideLength { get; set; }

        public double Area()
        {
            return 0;
        }

        public double Perimeter()
        {
            return 0;
        }
    }
}
