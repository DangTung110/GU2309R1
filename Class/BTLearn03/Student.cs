using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn03
{
    internal class Student
    {
        private int id;
        private string name;
        private static string college = "BBDIT";

        public Student(int id = 0, string name = "No Name") 
        {
            this.id = id;
            this.name = name;
        }

        public static void Change()
        {
            college = "Thang Long";
        }
        public void Display()
        {
            Console.WriteLine("ID: "+ id + " | Name: " + name + " | " + college);
        }
        ~Student() { }
    }
}
