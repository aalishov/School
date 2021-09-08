using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //First rows
        for (int i = 1; i < n; i++)
        {
            Console.Write(new string(' ',n-i));
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        //Middle row
        for (int i = 1; i < n; i++)
        {
            Console.Write("* ");
        }
        Console.WriteLine("*");

        //Last rows
        for (int i = n - 1; i >= 1; i--)
        {
            Console.Write(new string(' ', n - i));
            for (int j = i; j >= 1; j--)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}

