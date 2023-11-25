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
            List <Shape> shapes = new List <Shape> ();
            shapes.Add (new Circle ());
            shapes.Add (new Rectangle ());
            shapes.Add (new Square ());

            Random rd = new Random ();
            double percent = rd.Next (1, 100);
            percent = percent / 100;

            Circle c = new Circle (3);
            c.Resize(percent);

            Square s = new Square ();
            Console.WriteLine( s.GetLength());
            s.Resize(percent);
            Console.WriteLine(s.GetLength());

            Console.ReadKey();
        }
    }
}
