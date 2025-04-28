using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTask
{
    class Trapezoid : Shape
    {
        private double _base1Length;
        private double _base2Length;
        private double _height;

        // Properties for the trapezoid's base lengths and height
        public double Base1Length
        {
            get => _base1Length;
            private set => _base1Length = value > 0 ? value : throw new ArgumentException("Base1 must be positive.");
        }

        public double Base2Length
        {
            get => _base2Length;
            private set => _base2Length = value > 0 ? value : throw new ArgumentException("Base2 must be positive.");
        }

        public double Height
        {
            get => _height;
            private set => _height = value > 0 ? value : throw new ArgumentException("Height must be positive.");
        }

        public Trapezoid(double base1Length, double base2Length, double height, string color)
        {
            Base1Length = base1Length;
            Base2Length = base2Length;
            Height = height;
            Color = color;
        }

        // Calculate the area of the trapezoid
        public override double GetArea() => 0.5 * (Base1Length + Base2Length) * Height;

        public override void DisplayShape()
        {
            Console.WriteLine($"Shape: Trapezoid, Area: {GetArea():0.##} sq.units, Bases: {Base1Length} units and {Base2Length} units, Height: {Height} units, Color: {Color}.");
        }
    }
}
