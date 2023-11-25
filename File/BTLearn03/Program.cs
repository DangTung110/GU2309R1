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
            Book book = new Book();
            bool isWriten = book.WriteToFile();
            if (isWriten)
            {
                book.ReadFromFile();
            }
            else
            {
                System.Console.WriteLine("Write data to file occur an error. Please try again !");
            }

            Console.ReadKey();
        }
    }
}
