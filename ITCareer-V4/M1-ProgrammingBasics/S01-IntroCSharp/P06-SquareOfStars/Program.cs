using System;


class Program
{
    static void Main()
    {
        //Input
        int n = int.Parse(Console.ReadLine());

        //First row
        Console.WriteLine(new string('*',n));

        //Middle rows
        for (int i = 1; i <= n-2; i++)
        {
            Console.WriteLine($"*{new string(' ',n-2)}*");
        }

        //Last row
        Console.WriteLine(new string('*', n));
    }
}

