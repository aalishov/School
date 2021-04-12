using System;
using System.IO;
using System.Text;

namespace P05_Height
{
    class Program
    {
        static void Main()
        {
            string path = @"D:\GIT\School\School-2020_2021\8B_Solutions\S05-Files\P05-Height\students.txt";
            StreamReader r = new StreamReader(path, Encoding.UTF8);
            int maxNum = 0, maxHeight = 0;
            string line = "";
            while ((line = r.ReadLine()) != null)
            {
                //1,175
                string[] info = line.Split(',');
                int num = int.Parse(info[0]);
                int height = int.Parse(info[1]);

                if (height > maxHeight)
                {
                    maxHeight = height;
                    maxNum = num;
                }
            }
            Console.WriteLine($"Най-високият ученик от класа е с номер {maxNum}{Environment.NewLine}и е висок {maxHeight} см.");
        }
    }
}
