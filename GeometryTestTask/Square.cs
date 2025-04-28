using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTask
{
    class Square : Shape
    {
        private double _sideLength;

        // Property for the side length of the square
        public double SideLength
        {
            get => _sideLength;
            private set => _sideLength = value > 0 ? value : throw new ArgumentException("Side length must be positive.");
        }

        public Square(double sideLength, string color)
        {
            SideLength = sideLength;
            Color = color;
        }

        // Calculate the area of the square
        public override double GetArea() => SideLength * SideLength;

        public override void DisplayShape()
        {
            Console.WriteLine($"Shape: Square, Area: {GetArea():0.##} sq.units, Side length: {SideLength} units, Color: {Color}.");
        }
    }
}
