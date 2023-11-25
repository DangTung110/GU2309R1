using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, m, count = 2;

            Console.WriteLine("Moi nhap n, m cho ma tran A[n][m]: ");
            while (!int.TryParse(Console.ReadLine(), out n) || !int.TryParse(Console.ReadLine(), out m) || n < 0 || m < 0)
            {
                if (count != 0)
                {
                    Console.WriteLine("Error. Vui long nhap lai n, m: ");
                    count--;
                }
                else
                {
                    Console.WriteLine("Ban da het luot de nhap.");
                    return;
                }
            }

            int[, ] array = new int[n, m];
            int max = 0;
            Random rnd = new Random();

            for (int i = 0; i < n; i++) 
            {
                for (int j = 0; j < m; j++)
                {
                    array[i, j] = rnd.Next(0, 10);
                    Console.Write(array[i, j] + "   ");
                    if (array[i, j] > max)  max = array[i, j];
                }

                Console.WriteLine();
            }

            Console.WriteLine("=======================") ;

            #region xuất ma trận
            for (int i = 0, j = 0; i < n && j < m; j++)
            {
                Console.WriteLine();
            }
            #endregion

            #region xuất ma trận tam giác trên
            if (m == n)
            {
                for (int i = 0, j = 0; i < n && j < m; j++)
                {
                    if (i <= j) Console.Write(array[i, j] + "   ");
                    if (j == m - 1)
                    {
                        i++;
                        j = 0;
                        Console.WriteLine();
                    }
                }
            }
            else Console.WriteLine("Ma tran khong ton tai ma tran tam giac tren!");
            #endregion


            List <int> maTran = new List < int>();

            Console.WriteLine("Phan tu lon nhat: {0}", max);

            Console.ReadKey();
        }
    }
}
