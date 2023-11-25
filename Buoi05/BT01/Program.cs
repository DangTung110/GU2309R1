using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = -1, count = 2;
            int donVi, chuc, tram;

            Console.Write("Enter number: ");

            nhap_so:
                if (int.TryParse(Console.ReadLine(), out number) && number > 0 && number < 1000 && count > 0)
                {
                    donVi = number % 10;
                    chuc = ((number - donVi) % 100) / 10;
                    tram = number / 100;
                }
                else
                {
                    if (count < 0) goto luot_dem;

                    Console.Write("Error. Please again number: ");
                    count--;
                    goto nhap_so;
                }

            if (tram > 0 && tram < 10)
            {
                switch (tram)
                {
                    case 1:
                        Console.Write("one");
                        break;
                    case 2:
                        Console.Write("two");
                        break;
                    case 3:
                        Console.Write("three");
                        break;
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    case 9:
                        Console.Write("nine");
                        break;
                }

                Console.Write(" hundred and ");
            }


            if (chuc > 1)
            {
                switch (chuc)
                {
                    case 1:
                        Console.Write("one");
                        break;
                    case 2:
                        Console.Write("two");
                        break;
                    case 3:
                        Console.Write("three");
                        break;
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    case 9:
                        Console.Write("nine");
                        break;
                }

                Console.Write("ty ");
            }
   
            switch (donVi)
            {
                case 1:
                    Console.Write("one");
                    break;
                case 2:
                    Console.Write("two");
                    break;
                case 3:
                    Console.Write("three");
                    break;
                case 4:
                    Console.Write("four");
                    break;
                case 5:
                    Console.Write("five");
                    break;
                case 6:
                    Console.Write("six");
                    break;
                case 7:
                    Console.Write("seven");
                    break;
                case 8:
                    Console.Write("eight");
                    break;
                case 9:
                    Console.Write("nine");
                    break;
            }
            if (chuc == 1)
            {
                Console.WriteLine("teen");
            }

        luot_dem: 
            Console.WriteLine("");
            Console.WriteLine("==========================================");
        }
    }
}
