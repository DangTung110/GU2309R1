using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "dang duy tung";
            char a = ' ';
            Input(ref a);
            
            List <char> lstChar = new List<char>();
            List <int> lstCount = new List<int>();

            TimKiem(ref lstChar,ref lstCount, str);

            if (lstChar.Contains(a))
            {
                int index = lstChar.IndexOf(a);
                Console.WriteLine(a + " xuat hien: {0} lan", lstCount[index]);
            }
            else  Console.WriteLine("Khong co ky tu " + a);
            
            Console.ReadKey();
        }

        static void Input(ref char a)
        {
            int count = 2;
            Console.Write("Moi nhap ky tu ban muon tim: ");
            while (!char.TryParse(Console.ReadLine(), out a))
            {
                if (count > 0)
                {
                    Console.Write("Error. Vui long nhap lai: ");
                    count--;
                }
                else
                {
                    Console.WriteLine("Ban da het so lan nhap!");
                    return;
                }
            }
        }

        static void TimKiem(ref List<Char> lstChar, ref List<int> lstCount, string str) 
        {
            int index;
            for (int i = 0; i < str.Length; i++)
            {
                if (lstChar.Contains(str[i]))
                {
                    index = lstChar.IndexOf(str[i]);
                    lstCount[index] ++;
                    //Console.WriteLine(str[i]);
                }
                else
                {
                    lstChar.Add(str[i]);
                    lstCount.Add(1);
                }
            }

            Console.WriteLine(string.Join(", ", lstChar.Select(temp => temp)));
            Console.WriteLine(string.Join(", ", lstCount.Select(temp => temp)));
        }

    }
}
