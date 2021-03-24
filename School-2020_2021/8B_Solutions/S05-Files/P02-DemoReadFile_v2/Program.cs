using System;
using System.IO;
using System.Text;

namespace P02_DemoReadFile_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\GIT\School\School-2020_2021\8B_Solutions\S05-Files\P02-DemoReadFile_v2\read.txt";
            StreamReader r = new StreamReader(path, Encoding.UTF8);

            string line = string.Empty;

            while (line != null)
            {
                line = r.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
