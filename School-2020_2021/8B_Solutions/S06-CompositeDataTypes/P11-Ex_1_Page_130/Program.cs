using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"D:\GIT\School\School-2020_2021\8B_Solutions\S06-CompositeDataTypes\P11-Ex_1_Page_130\file.txt";

        Console.Write("Enter numbers count: ");
        int n = int.Parse(Console.ReadLine());

        Random random = new Random();

        using (StreamWriter writer = new StreamWriter(path, true))
        {
            Console.WriteLine($"You enter: {n}");
            writer.WriteLine($"You enter: {n}");

            for (int i = 0; i < n; i++)
            {
                int number = random.Next(-100000, 100000);
                string result = $"Random number {i + 1}: {number}";
                Console.WriteLine(result);
                writer.WriteLine(result);
            }
            writer.WriteLine(new string('*', 20));
        }

    }
}

