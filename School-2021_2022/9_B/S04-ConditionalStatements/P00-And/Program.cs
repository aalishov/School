using System;

namespace P00_And
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0 && num % 2 == 0)
            {
                Console.WriteLine("Even and positive");
            }
        }
    }
}
