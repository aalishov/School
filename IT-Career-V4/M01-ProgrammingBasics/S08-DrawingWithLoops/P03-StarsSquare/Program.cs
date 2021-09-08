using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine("*");
        }
    }
}

