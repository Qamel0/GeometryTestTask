using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTask
{
    class Program
    {
        static void Main()
        {
            var random = new Random();
            var shapes = new List<Shape>();

            // Generate a random number of shapes (from 1 to 10) and fill the list with random shapes
            for (int i = 0; i < random.Next(1, 10); i++)
            {
                Shape shape = GenerateRandomShape(random);
                shapes.Add(shape);
            }

            Console.WriteLine("Generated Shapes:\n");

            //Output information about each shape
            foreach (var shape in shapes)
            {
                shape.DisplayShape();
            }
        }

        // Method to generate a random shape with random properties
        private static Shape GenerateRandomShape(Random random)
        {
            string[] colors = { "Red", "Blue", "Green", "Yellow", "Purple", "Orange" };

            string color = colors[random.Next(colors.Length)];

            // Randomly select a shape type and create the corresponding object
            switch (random.Next(0,4))
            {
                case 0: // Square
                    double side = Math.Round(random.NextDouble() * 10 + 1, 2);
                    return new Square(side, color);

                case 1: // Triangle
                    double baseLength = Math.Round(random.NextDouble() * 10 + 1, 2);
                    double height = Math.Round(random.NextDouble() * 10 + 1, 2);
                    return new Triangle(baseLength, height, color);

                case 2: // Circle
                    double radius = Math.Round(random.NextDouble() * 5 + 1, 2);
                    return new Circle(radius, color);

                case 3: // Trapezoid
                    double base1 = Math.Round(random.NextDouble() * 10 + 1, 2);
                    double base2 = Math.Round(random.NextDouble() * 10 + 1, 2);
                    double trapHeight = Math.Round(random.NextDouble() * 5 + 1, 2);
                    return new Trapezoid(base1, base2, trapHeight, color);

                default:
                    throw new InvalidOperationException("Unknown shape type.");
            }
        }
    }
}
