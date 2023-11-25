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
            int size = -1;
            List<int> listIndex = new List<int>() { 0 };

            InputSize(ref size);

            int[] array = new int[size];
            RandomArray(ref array);

            ListIndexMinArray(array, ref listIndex);

            Console.WriteLine("Vi tri cua gia tri min:");
            Console.WriteLine(string.Join(", ", listIndex.Select(a => a)));

            Console.ReadKey();
        }

        static void RandomArray(ref int[] array)
        {
            Random rd = new Random();
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                temp = rd.Next(0, 5);

                //if (array.Contains(temp))  i--;
                //else array[i] = temp;

                array[i] = temp;
            }

            Console.WriteLine(string.Join(", ", array));
        }


        static List<int> ListIndexMinArray(int[] arr,ref List <int> indexMin)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    indexMin.Clear();
                    indexMin.Add(i);
                }
                else if (arr[i] == min) indexMin.Add(i);
            }


            return indexMin;
        }

        static void InputSize(ref int size)
        {
            int count = 2;
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
                    return;
                }
            }
        }


    }
}
