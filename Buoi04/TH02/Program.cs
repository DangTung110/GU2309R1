using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float width, height;
            float area;

            Console.WriteLine("Enter width: ");
            width = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter height: ");
            height = float.Parse(Console.ReadLine());

            area = width * height;
            Console.WriteLine("Area is: "+ area);
        }
    }
}
