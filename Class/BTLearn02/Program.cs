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
            Cat cat = new Cat("10kg", "1.25", "meow");
            cat.PrintInfo();

            Console.ReadKey();
        }
    }
}
