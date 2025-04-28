using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTask
{
    // Abstract base class for all shapes
    abstract class Shape
    {
        public string Color { get; set; } = null!;

        // Abstract method to calculate the area
        public abstract double GetArea();

        // Abstract method to display information about the shape
        public abstract void DisplayShape();
    }
}
