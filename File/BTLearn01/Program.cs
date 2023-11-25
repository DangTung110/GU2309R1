using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace BTLearn01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File file = new File();
            string path = @"D:\VISUAL STUDIO\GU2309R1\File\BTLearn01\data.txt";
            file.ReadFile(path);

            Console.ReadKey();
        }
    }
}
