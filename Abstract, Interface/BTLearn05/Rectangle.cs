using BTLearn05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn01
{
    internal class Rectangle : Shape
    {
        double width, length;

        public Rectangle(double width = 1.0, double length = 1.0)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(string color, bool filled, double width, double length) : base(color, filled)
        {
            this.width = width;
            this.length = length;
        }
        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }
        public virtual void SetWidth(double width)  {this.width = width;}
        public virtual void SetLength(double length)  {this.length = length;}
        public double GetWidth() { return width;}
        public double GetLength() { return length;}
        public override double GetArea() { return width * length; }
        public double GetPerimeter() { return (length + width) * 2; }
        public override string ToString() 
        {
            return "A Rectangle with width = " + width + " and length = " + length + ", which is a subclass of " + base.ToString(); 
        }
        public void Resize(double percent)
        {
            width = width * (1 + percent);
            length = length * (1 + percent);
        }
    }
}
