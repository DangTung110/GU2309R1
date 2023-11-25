using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn01
{
    internal class Shape
    {
        string color;
        bool filled;
        public Shape(string color = "green", bool filled = true) 
        {
            this.color = color;
            this.filled = filled;
        }
        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }
        public override string ToString() 
        { 
            if (filled) return "A Shape with color of " + color + " and filled";
            return "A Shape with color of " + color + " and not filled"; 
        }
    }
}
