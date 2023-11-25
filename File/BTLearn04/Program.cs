using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listA = new List<string>();
            try
            {
                using (var reader = new StreamReader(@"D:\VISUAL STUDIO\GU2309R1\File\BTLearn04\data.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split('\n');

                        listA.Add(values[0]);
                    }
                }
            }
            catch (Exception ex)  
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(string.Join("\n", listA.Select(temp => temp)));

            Console.ReadKey();
        }
    }
}
