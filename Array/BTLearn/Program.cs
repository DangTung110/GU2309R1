using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);

            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            Console.WriteLine("Tong cac phan tu trong mang: " + total);

           

            List <int> list = new List<int>();
            int size = -1, count = 3, temp;
            Console.Write("Ban muon nhap bao nhieu phan tu: ");

            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                if (count > 0)
                {
                    Console.Write("Error. Vui long nhap lai size: ");
                    count--;
                }
                else
                {
                    Console.WriteLine("Ban da het so lan nhap!");
                    return;
                }
            }

            count = 3;
            for (int i = 0; i < size; i++)
            {
                Console.Write("Moi nhap phan tu thu [{0}]: ", i);
                while (!int.TryParse(Console.ReadLine(), out temp))
                {
                    if (count > 0)
                    {
                        Console.Write("Error. Vui long nhap lai phan tu [{0}]: ", i);
                        count--;
                    }
                    else
                    {
                        Console.WriteLine("Ban da het so lan nhap!");
                        return;
                    }
                }

                list.Add(temp);
            }

            Console.WriteLine("Tong cac phan tu trong List: {0}", list.Sum());


            Console.ReadKey();
        }
    }
}
