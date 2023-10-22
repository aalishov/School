using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P00_SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> files = Directory.EnumerateFiles("C:\\Users\\aalis\\Desktop\\").ToList();

            Console.WriteLine(string.Join("\n\r", files));

            foreach (var file in files)
            {
                int dotIndex = file.LastIndexOf('.');
                int slashIndex = file.LastIndexOf("\\");
                string fileName = file.Substring(slashIndex);
                string type = file.Substring(dotIndex);
                Console.WriteLine(type);
                if (type == ".docx")
                {
                    if (!Directory.Exists("Documents"))
                    {
                        Directory.CreateDirectory("Documents");
                    }
                    File.Copy(file, $"Documents\\{fileName}");
                }
                else if (type == ".sql")
                {
                    if (!Directory.Exists("DataBase"))
                    {
                        Directory.CreateDirectory("DataBase");
                    }
                    File.Copy(file, $"DataBase\\{fileName}");
                }
                else if (type == ".pdf")
                {
                    if (!Directory.Exists("Print"))
                    {
                        Directory.CreateDirectory("Print");
                    }
                    File.Copy(file, $"Print\\{fileName}");
                }
            }
        }
    }
}
