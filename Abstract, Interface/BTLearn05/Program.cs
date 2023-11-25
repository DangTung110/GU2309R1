using BTLearn01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> lst = new List<Shape>();
            lst.Add(new Rectangle(3.1, 12));
            lst.Add(new Square(3.5));
            lst.Add(new Circle(2.51));

            foreach (Shape s in lst)
            {
                Console.WriteLine(s.GetArea());

                if (s is Square)
                {
                    IColorable c = (Square)s;
                    c.HowToColor();
                }
            }

            Console.ReadKey();
        }
    }
}
