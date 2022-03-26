using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> input = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToList();
        List<int> elements = Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToList();
        Queue<int> queue = new Queue<int>();
        foreach (var element in elements)
        {
            queue.Enqueue(element);
        }
        int dequeueCount = input[1];
        for (int i = 0; i < dequeueCount; i++)
        {
            queue.Dequeue();
        }
        if (queue.Count == 0) { Console.WriteLine(0); }
        else if (queue.Contains(input[2]))
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine(queue.ToArray().Min());
        }
    }
}

