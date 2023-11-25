using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var writer = new StreamWriter(@"D:\VISUAL STUDIO\GU2309R1\File\BTLearn05\data.txt"))
                {
                    Console.WriteLine("Thong tin san pham: ");
                    Console.Write("Ma san pham: ");
                    writer.WriteLine("Ma san pham: " + Console.ReadLine());
                    Console.Write("Ten san pham: ");
                    writer.WriteLine("Ten san pham: " + Console.ReadLine());
                    Console.Write("Hang san pham: ");
                    writer.WriteLine("Hang san pham: " + Console.ReadLine());
                    Console.Write("Gia san pham: ");
                    writer.WriteLine("Gia san pham: " + Console.ReadLine());
                    Console.Write("Cac mo ta khac: ");
                    writer.WriteLine("Cac mo ta khac: " + Console.ReadLine());
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
