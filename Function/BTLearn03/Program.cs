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
            int size = -1, valueDel;
            List<int> list = new List<int>();

            size = InputSize();
            RandomArray(ref list, size);
            valueDel = InputValueDel();
            DelValue(ref list, valueDel);

            Console.WriteLine("==================================");
            Console.WriteLine("Mang sau khi xoa");
            Console.WriteLine(string.Join(", ", list.Select(a => a)));

            Console.ReadKey();
        }

        static void RandomArray(ref List<int> list, int size)
        {
            Random rd = new Random();
            int temp;

            for (int i = 0; i < size; i++)
            {
                temp = rd.Next(0, 50);
                if (list.Contains(temp)) i--;
                else list.Add(temp);
            }

            Console.WriteLine(string.Join(", ", list.Select(a => a)));
        }


        static void DelValue(ref List<int> arr, int valueDel)
        {
            if (arr.Contains(valueDel)) arr.Remove(valueDel);
            else Console.WriteLine("Mang khong co gia tri nay!");
        }


        static int InputSize()
        {
            int count = 2, size;
            Console.Write("Moi ban muon tao mang co bao nhieu phan tu: ");
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                if (count >= 0)
                {
                    Console.WriteLine("Error. Vui long nhap lai size cho mang: ");
                    count--;
                }
                else
                {
                    Console.WriteLine("Ban da het luot nhap!");
                    Environment.Exit(0);
                }
            }

            return size;
        }

        static int InputValueDel()
        {
            int count = 2, value;
            Console.Write("Moi ban nhap gia tri muon xoa: ");
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                if (count >= 0)
                {
                    Console.WriteLine("Error. Vui long nhap lai gia tri: ");
                    count--;
                }
                else
                {
                    Console.WriteLine("Ban da het luot nhap!");
                    Environment.Exit(0) ;
                }
            }

            return value;
        }

    }
}
