using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int side = n - 1;
        int half = n - 2;

        PrintRows(half,'\\','/');

        Console.WriteLine($"{new string(' ', side)}@{new string(' ', side)}");

        PrintRows(half,'/','\\');
    }

    private static void PrintRows(int half,char c1,char c2)
    {
        for (int i = 0; i < half; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{new string('*', half)}{c1} {c2}{new string('*', half)}");
            }
            else
            {
                Console.WriteLine($"{new string('-', half)}{c1} {c2}{new string('-', half)}");
            }
        }
    }
}

