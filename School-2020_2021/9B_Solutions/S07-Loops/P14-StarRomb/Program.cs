using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            string line = new string(' ', n - row) + "*";
            
            for (int i = 0; i < row - 1; i++)
            {
                line += " *";
            }

            Console.WriteLine(line);
        }

        for (int row = n-1; row >= 1; row--)
        {
            string line = new string(' ', n - row) + "*";

            for (int i = 0; i < row - 1; i++)
            {
                line += " *";
            }

            Console.WriteLine(line);
        }

    }
}

