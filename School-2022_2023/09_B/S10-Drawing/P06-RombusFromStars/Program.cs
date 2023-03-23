using System;

namespace P06_RombusFromStars
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int j = 0; j < n - row; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= row; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int row = 1; row <= n-1; row++)
            {
                for (int j = 1; j < row; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= n-row; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
