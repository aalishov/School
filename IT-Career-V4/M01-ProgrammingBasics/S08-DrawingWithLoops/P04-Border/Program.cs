using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //First row
        Console.Write("+ ");
        for (int i = 1; i <= n-2; i++)
        {
            Console.Write("- ");
        }
        Console.WriteLine("+");

        //Middle rows

        for (int i = 1; i <= n-2; i++)
        {
            Console.Write("| ");
            for (int j = 1; j <= n - 2; j++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("|");
        }

        //Last row
        Console.Write("+ ");
        for (int i = 1; i <= n - 2; i++)
        {
            Console.Write("- ");
        }
        Console.WriteLine("+");
    }
}

