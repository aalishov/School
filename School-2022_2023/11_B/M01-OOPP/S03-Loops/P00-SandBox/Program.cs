using System;

namespace P00_SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string even = "Even: ";
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                int num = int.Parse(input);
                if (num % 2 == 0)
                {
                    even += num + " ";
                }
            }

            Console.WriteLine(even);
        }
    }
}

