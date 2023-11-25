using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn02
{
    internal class Cylinder : Circle
    {
        private double height;

        public Cylinder(double height, double radius, string color) : base(radius, color)
        {
            this.height = height;
        }
        public double Height { get => height; set => this.height = value;}
        public double GetVolume() { return  height * GetArea(); }
        public override string ToString()
        {
            return base.ToString() + string.Format("\nVolume: {0}", GetVolume());
        }
    }
}
