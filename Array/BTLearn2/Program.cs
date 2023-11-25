using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("Enter a name’s student:");
            string input_name = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input_name))
                {
                    Console.WriteLine("Position of the students in the list " + input_name + " is: " + (i + 1));
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Not found" + input_name + " in the list.");
            }

// List
            List<string> students_list = new List<string>();
            string student;
            bool check;
            int index;

            for (int i = 0;i < students.Length;i++)
            {
                students_list.Add(students[i]);
            }

            Console.WriteLine("=============================");
            Console.Write("Ban muon tim ai: ");
            student = Console.ReadLine();
            check = students_list.Contains(student);
            index = students_list.IndexOf(student);

            if (check)  Console.WriteLine("{0} co trong danh sach va o vi tri: {1}", student, index + 1);
            else Console.WriteLine("{0} khong co trong danh sach!", student);

            Console.ReadKey();
        }
    }
}
