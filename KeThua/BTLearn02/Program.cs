using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder c = new Cylinder(1.3, 2.2, "Red");
            Console.WriteLine(c.GetVolume());
            Console.WriteLine(c.ToString());

            Console.ReadKey();
        }
    }
}
