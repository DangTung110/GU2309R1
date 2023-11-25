using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn01
{
    internal class Program
    {
        static double ToCelsius(float f)
        {
            return (5.0 / 9) * (f - 32);
        }

        static double ToFahrenheit(float c)
        {
            return c * (9.0 / 5) + 32;
        }

        static void Main(string[] args)
        {
            int choice = -1, count = 2;

            Console.WriteLine("1. Fahrenheit to Celsius\n2. Celsius to Fahrenheit\n0. Exit ");
            Console.Write("Moi nhap lua chon cua ban: ");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 0 || choice > 2)
            {
                if (count > 0)
                {
                    Console.Write("Error. Vui long nhap lai lua chon cua ban: ");
                    count--;
                }
                else
                {
                    Console.WriteLine("Ban da het luot nhap!");
                    return;
                }
                
            }

            switch (choice)
            {
                case 1:
                    float f;
                    Console.Write("Moi nhap do F: ");
                    while (!float.TryParse(Console.ReadLine(), out f))
                    {
                        if (count > 0)
                        {
                            Console.Write("Error. Vui long nhap lai do F: ");
                            count--;
                        }
                        else
                        {
                            Console.WriteLine("Ban da het luot nhap!");
                            return;
                        }

                    }
                    Console.WriteLine("{0} Fahrenheit to Celsius: {1}C", f, ToCelsius(f));

                    break;
                case 2:
                    float c;
                    Console.Write("Moi nhap do C: ");
                    while (!float.TryParse(Console.ReadLine(), out c))
                    {
                        if (count > 0)
                        {
                            Console.Write("Error. Vui long nhap lai do C: ");
                            count--;
                        }
                        else
                        {
                            Console.WriteLine("Ban da het luot nhap!");
                            return;
                        }

                    }
                    Console.WriteLine("{0} Celsius to Fahrenheit: {1}",c, ToFahrenheit(c)); 

                    break;
                default:
                    break;
            }


            Console.ReadKey();
        }
    }
}
