using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2D point2D = new Point2D(2, 3.2);
            Console.WriteLine(point2D.ToString());

            Point3D point3D = new Point3D(2, 3.2, 3);
            Console.WriteLine(point3D.ToString());
            Console.WriteLine(string.Join(" ",point3D.GetXYZ()));

            Console.ReadKey();
        }
    }
}
