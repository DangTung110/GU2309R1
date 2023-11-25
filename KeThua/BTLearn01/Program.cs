using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            Console.WriteLine(shape);
            shape = new Shape("red", false);
            Console.WriteLine(shape);
            Console.WriteLine("=====================================");

            Circle circle = new Circle();
            Console.WriteLine(circle);
            circle = new Circle(3.5);
            Console.WriteLine(circle);
            circle = new Circle("indigo", false, 3.5);
            Console.WriteLine(circle);
            Console.WriteLine("=====================================");

            Rectangle rectangle = new Rectangle();
            Console.WriteLine(rectangle);
            rectangle = new Rectangle(2.3, 5.8);
            Console.WriteLine(rectangle);
            rectangle = new Rectangle("orange", true, 1.4, 13.2);
            Console.WriteLine(rectangle);
            Console.WriteLine("=====================================");

            Square square = new Square();
            Console.WriteLine(square);
            square = new Square(2.3);
            Console.WriteLine(square);
            square = new Square("yellow", true, 5.3);
            Console.WriteLine(square);

            Console.ReadKey();
        }
    }
}
