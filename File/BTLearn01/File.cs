using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn01
{
    internal class File
    {
        public File() { }
        public void ReadFile(string path)
        {
            try
            {
                FileInfo file = new FileInfo(path);
            }
            catch (FileNotFoundException ex)
            {
                Console.Write("Loi: ");
                Console.WriteLine(ex.Message);
            }

            StreamReader reader = new StreamReader(path);
            string line = "";
            int sum = 0;
            while ((line = reader.ReadLine()) != null)  //Kiểm tra hết dữ liệu chưa. reader.ReadLine() đọc từng dòng dữ liệu.
            {
                Console.WriteLine(line);
                sum += int.Parse(line);
            }
            reader.Close();
            Console.WriteLine("Total: " + sum);
        }
    }
}
