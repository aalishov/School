using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<int> q = new Queue<int>();

        Console.Write("Enter first element: ");
        q.Enqueue(int.Parse(Console.ReadLine()));

        Console.WriteLine($"S1={q.Peek()}");
        int sCounter = 1;

        for (int i = 1; i <= 50/3+1; i++)
        {
            int current = q.Dequeue();
            int first = current + 1;
            q.Enqueue(first);
            Console.WriteLine($"S{++sCounter}={first}");
            int second = 2 * current + 1;
            q.Enqueue(second);
            Console.WriteLine($"S{++sCounter}={second}");
            int third = current + 2;
            q.Enqueue(third);
            Console.WriteLine($"S{++sCounter}={third}");
        }

    }
}

