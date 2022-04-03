using System;
using System.IO;

public class Program
{
    static void Main()
    {
        string path = @"C:\Users\Alishov\Desktop\School\School-2021_2022\8_B\S02-ConditionalStatementsAndLoops\P18-Students\students.txt";

        while (true)
        {
            Console.Write("Enter command (Add,Print,End): ");
            string cmd = Console.ReadLine().ToLower();
            if (cmd=="add")
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter school: ");
                string school = Console.ReadLine();
                using (StreamWriter writer= new StreamWriter(path,true))
                {
                    writer.WriteLine($"{name} - {school}");
                }
            }
            else if (cmd=="print")
            {
                Console.WriteLine(new string('-',10));
                Console.WriteLine("Students:");
                using (StreamReader reader= new StreamReader(path))
                {
                    string line = string.Empty;
                    while (line!=null)
                    {
                        line = reader.ReadLine();
                        Console.WriteLine($"\t{line}");
                    }
                }
            }
            else if (cmd=="end")
            {
                Environment.Exit(0);
            }
        }
    }
}

