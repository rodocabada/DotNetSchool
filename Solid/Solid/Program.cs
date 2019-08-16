using System;
using static System.Console;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {

            var shapeCalculator = new ShapeCalculator(CreateShapes());

            shapeCalculator.CalculateAreas();
            shapeCalculator.CalculatePerimeters();

            WriteLine(shapeCalculator.TotalAreas);
            WriteLine(shapeCalculator.TotalPerimeters);
            ReadKey();

        }

        private static IGeometricShape[] CreateShapes() =>
            new IGeometricShape[]
            {
                new Rectangle
                {
                    Height = 4,
                    Width = 5
                },
                new Triangle
                {
                    SideLength = 10
                },
                new Square
                {
                    Height = 5
                }
            };
    }
}
