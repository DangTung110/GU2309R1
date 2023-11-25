using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, count = 2;

            Console.Write("Moi nhap kich thuoc cho mang MxM: ");
            while (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
            {
                if (m != 0)
                {
                    Console.Write("Error. Vui long nhap lai: ");
                    count--;
                }
                else
                {
                    Console.WriteLine("Ban da het luot de nhap, vui long chay lai chuong trinh. \nThanks!");
                    return;
                }
            }
            float[,] array = new float[m,m];
            float sum = 0;
            count = 2;

        #region Nhap du lieu cho ma tran
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("[{0}][{1}]: ",i + 1,j + 1);
                    while(!float.TryParse(Console.ReadLine(), out array[i,j]))
                    {
                        if (count != 0)
                        {
                            Console.Write("Error. Vui long nhap lai gt tai [{0}][{1}]: ", i + 1, j + 1);
                        }
                    }
                    if (i == j) sum += array[i,j];
                }
            }
            #endregion

            #region Hien thi ma tran
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + "   ");
                }
                Console.WriteLine();
            }
            #endregion


            Console.WriteLine("Tong duong cheo chinh la: {0}", sum);


            Console.ReadKey();
        }
    }
}
