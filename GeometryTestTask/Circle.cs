using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTask
{
    class Circle : Shape
    {
        private double _radius;

        // Property for the radius of the circle
        public double Radius
        {
            get => _radius;
            private set => _radius = value > 0 ? value : throw new ArgumentException("Radius must be positive.");
        }

        public Circle(double radius, string color)
        {
            Radius = radius;
            Color = color;
        }

        // Calculate the area of the circle
        public override double GetArea() => 3.14 * Radius * Radius;

        public override void DisplayShape()
        {
            Console.WriteLine($"Shape: Circle, Area: {GetArea():0.##} sq.units, Radius: {Radius} units, Color: {Color}.");
        }
    }
}
