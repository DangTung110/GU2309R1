using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn01
{
    internal class Circle : Shape
    {
        double radius;
        double PI = 3.14;
        public Circle() { this.radius = 1.0; }
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(string color, bool filled, double radius) : base(color, filled)
        {
            this.radius = radius;
        }
        public double GetArea() { return PI * radius * radius; }
        public double GetPerimeter() { return 2 * PI * radius; }
        public double Radius { get => this.Radius; set => this.Radius = value; }
        public override string ToString() { return "A Circle with radius = " + this.radius + ", which is a subclass of " + base.ToString(); }
    }
}
