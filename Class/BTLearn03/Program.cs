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
            Student.Change();

            Student s1 = new Student(1, "Pham");
            Student s2 = new Student(2, "An");

            s1.Display();
            s2.Display();

            Console.ReadKey();
        }
    }
}
