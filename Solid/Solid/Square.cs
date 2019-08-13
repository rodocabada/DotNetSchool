using System;
using System.Collections.Generic;
using System.Text;

namespace Solid
{
    public class Square : IGeometricShape
    {
        public double Height { get; set; }

        public double Area()
        {
            throw new NotImplementedException();
        }

        public double Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}
