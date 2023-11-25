using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;

            Console.WriteLine("Menu:");
            Console.WriteLine("1.Print the rectangle.");
            Console.WriteLine("2.Print the square triangle(The corner is square at 4 different angles: top - left, top - right, botton - left, botton - right).");
            Console.WriteLine("3.Print isosceles triangle.");
            Console.WriteLine("4.Exit.");

            Console.Write("Moi nhap lua chon: ");

            if (int.TryParse(Console.ReadLine(), out choice) && choice < 0 && choice > 4) Console.WriteLine("Error!");
            else
            {
                switch (choice)
                {
                    case 1:
                        int chieuDai, chieuRong;
                        Console.Write("Moi nhap chieu dai: ");
                        chieuDai = int.Parse(Console.ReadLine());

                        Console.Write("Moi nhap chieu rong: ");
                        chieuRong = int.Parse(Console.ReadLine());

                        for (int i = 0; i < chieuDai; i++)
                        {
                            for (int j = 0; j < chieuRong; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        int canh;
                        Console.Write("Moi nhap canh huyen: ");
                        canh = int.Parse(Console.ReadLine());

                        for (int i = 0; i < canh; i++)
                        {
                            int count = canh - i;
                            for (int j = 0; j < count; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("=========");

                        for (int i = 0; i < canh; i++)
                        {
                            for (int j = 0; j < i + 1; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("=========");

                        for (int i = 0; i < canh; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write(" ");
                            }

                            for (int j = 0; j < canh - i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        Console.WriteLine("=========");

                        for (int i = 0; i < canh; i++)
                        {
                            for (int j = 0; j < canh - i; j++)
                            {
                                Console.Write(" ");
                            }

                            for (int j = 0; j < i + 1; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        int canhTG;
                        Console.Write("Moi nhap chieu dai canh: ");

                        canhTG = int.Parse(Console.ReadLine());
                        for (int i = 0; i < canhTG; i++)
                        {
                            for (int j = 0; j < canhTG - i; j++)
                            {
                                Console.Write(" ");
                            }

                            for (int j = 0; j < 2 * i + 1; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            }
           

            Console.ReadKey();
        }
    }
}
