using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTask
{
    class Triangle : Shape
    {
        private double _baseLength;
        private double _height;

        // Properties for the base length and height of the triangle
        public double BaseLength
        {
            get => _baseLength;
            private set => _baseLength = value > 0 ? value : throw new ArgumentException("Base length must be positive.");
        }

        public double Height
        {
            get => _height;
            private set => _height = value > 0 ? value : throw new ArgumentException("Height must be positive.");
        }

        public Triangle(double baseLength, double height, string color)
        {
            BaseLength = baseLength;
            Height = height;
            Color = color;
        }

        // Calculate the area of the triangle
        public override double GetArea() => 0.5 * BaseLength * Height;

        // Calculate the hypotenuse of the right-angled triangle
        public double GetHypotenuse() => Math.Sqrt(BaseLength * BaseLength + Height * Height);

        public override void DisplayShape()
        {
            Console.WriteLine($"Shape: Triangle, Area: {GetArea():0.##} sq.units, Hypotenuse: {GetHypotenuse():0.##} units, Color: {Color}.");
        }
    }
}
