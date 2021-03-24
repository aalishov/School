using System;
using System.IO;
using System.Text;

namespace P03_DemoWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\GIT\School\School-2020_2021\8B_Solutions\S05-Files\P03-DemoWriteFile\read.txt";

            StreamWriter w = new StreamWriter(path, false, Encoding.UTF8);

            for (int i = 0; i < 50; i++)
            {
                w.WriteLine($"i={i}");
            }
            w.Close();
        }
    }
}
