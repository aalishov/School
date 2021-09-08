using System;

class Program
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.WriteLine($"{i} {j}");
            }
        }
    }
}

