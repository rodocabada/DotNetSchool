using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    public class Square : IGeometricShape
    {
        public double Height { get; set; }

        public double Area() => Height * 2;

        public double Perimeter() => Height * 4;
    }
}
