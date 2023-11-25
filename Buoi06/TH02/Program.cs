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
            int number;
            bool check = true;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            //if (number < 2) Console.WriteLine(number + " is not a prime");
            //else
            //{
            //    int i = 2;
            //    bool check = true;
            //    while (i <= Math.Sqrt(number))
            //    {
            //        if (number % i == 0)
            //        {
            //            check = false;
            //            break;
            //        }
            //        i++;
            //    }

            //    if (check)
            //    {
            //        Console.WriteLine(number + " is a prime");
            //    }
            //    else
            //    {
            //        Console.WriteLine(number + " is not a prime");
            //    }
            //}

            if (number <= 3) ;
            else if (number % 2 == 0) check = false;
            else
            {
                for (int i = 3; i * i <= number; i += 2)
                {
                    if (number % i == 0)
                    {
                        check = false; 
                        break;
                    }
                }
            }

            if (check) Console.WriteLine(number + " is a prime");
            else Console.WriteLine(number + " is not a prime");

            Console.ReadKey();
        }
    }
}
