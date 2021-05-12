using System;
using System.IO;

namespace Ex_1_p_130
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Enter numbers count: ");
            int n = int.Parse(Console.ReadLine());

            Random random = new Random();

            //Да се създада нов файл и да се постави пътя до новия файл
            StreamWriter writer = new StreamWriter(@"D:\GIT\School\School-2020_2021\Blagova\Class8-2020_2021\Ex_1_p_130\file.txt", false);

            using (writer)
            {
                writer.WriteLine($"You enter number: {n}");

                for (int i = 0; i < n; i++)
                {
                    int number = random.Next(-5000, 5000);
                    string output = $"Random number {i + 1}: {number}";
                    Console.WriteLine(output);
                    writer.WriteLine(output);
                }
            }
        }
    }
}
