using BTLearn04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn01
{
    internal class Square : Rectangle, Resizeable
    {
        public Square(){}
        public Square(double side) : base(side, side){}
        public Square(String color, bool filled, double side) : base(color, filled, side, side){}

        public double GetSide() {return GetWidth();}

        public void SetSide(double side)
        {
            Width = side;
            Length = side;
        }
        public override void SetWidth(double width) 
        {
            SetSide(width);
        }
        public override void SetLength(double length)
        {
            SetSide(length);
        }
        public override String ToString()
        {
            return "A Square with side ="

                    + GetSide()

                    + ", which is a subclass of "

                    +base.ToString();

        }
        public void Resize(double percent)
        {
            SetSide(Width * (1 + percent));
        }
    }
}
