using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BTLearn02
{
    internal class CopyFile
    {
        public CopyFile() { }
        public void CopyFileUsingFileInfo(FileInfo source, FileInfo des)
        {
            Console.WriteLine("Start Copy using FileInfo");
            source.CopyTo(des.FullName, true);
        }
        public void CopyFileUsingStream(FileInfo source, FileInfo des)
        {
            Console.WriteLine("Start Copy using Stream");
            StreamReader reader = null;
            StreamWriter writer = null;
            try
            {
                reader = new StreamReader(source.FullName);
                writer = new StreamWriter(des.FullName);
                Char[] buffer = new Char[1024];
                int length;
                while ((length = reader.Read(buffer, 0, 0)) > 0)
                {
                    writer.Write(buffer, 0, length);
                }
            }
            finally
            {
                reader.Close();
                reader.Dispose();
                writer.Close();
                writer.Dispose();
            }
        }
    }
}
