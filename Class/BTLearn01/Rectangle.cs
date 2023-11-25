using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn01
{
    internal class Rectangle
    {
        private double width, heigh;

        public Rectangle (double width = 0.0, double heigh = 0.0)
        {
            this.width = width;
            this.heigh = heigh;
        }

        public double Width { get => width; set => width = value; }
        public double Heigh { get => heigh; set => heigh = value; }
        
        private double GetArea(){ return width * heigh; }

        private double GetPerimetor()
        { return 2*(width + heigh); }

        public void Display()
        {
            Console.WriteLine("Area: {0}\nPerimetor: {1}", GetArea(), GetPerimetor());
        }

        ~Rectangle() { Console.WriteLine("Finalizing object"); }
    }
}
