using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string firstRow = "+" + new string('-', n - 2) + "+";
        string middleRow = "|" + new string('-', n - 2) + "|";

        Console.WriteLine(firstRow);
        for (int i = 0; i < n-2; i++)
        {
            Console.WriteLine(middleRow);
        }
        Console.WriteLine(firstRow);
    }
}

