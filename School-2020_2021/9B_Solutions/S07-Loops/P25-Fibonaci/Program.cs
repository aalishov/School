using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89,
        int previous = 1;
        int current = 1;
        Console.WriteLine(previous);
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(current);
            int oldCurrent = current;
            current += previous;
            previous = oldCurrent;
        }
    }
}

