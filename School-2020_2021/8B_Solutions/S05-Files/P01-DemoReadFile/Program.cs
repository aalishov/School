using System;
using System.IO;
using System.Text;

namespace P01_DemoReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\GIT\School\School-2020_2021\8B_Solutions\S05-Files\P01-DemoReadFile\read.txt";
            StreamReader r = new StreamReader(path, Encoding.UTF8);

            string readFile = r.ReadToEnd();

            Console.WriteLine(readFile);
        }
    }
}
