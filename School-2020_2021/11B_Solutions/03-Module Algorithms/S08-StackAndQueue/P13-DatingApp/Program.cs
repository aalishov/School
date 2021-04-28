using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    private static Stack<int> males;
    private static Queue<int> females;

    private static int matchesCount = 0;
    public static void Main()
    {
        males = new Stack<int>(ReadArray());
        females = new Queue<int>(ReadArray());

        Matching();

        PrintOutput();
    }

    private static void Matching()
    {
        while (males.Any() && females.Any())
        {
            int man = males.Peek();
            if (man <= 0 || man % 25 == 0)
            {
                males.Pop();
                continue;
            }
            int woman = females.Peek();
            if (woman <= 0 || woman % 25 == 0)
            {
                females.Dequeue();
                continue;
            }
            males.Pop();
            females.Dequeue();
            if (man == woman)
            {
                matchesCount++;
            }
            else
            {
                males.Push(man -= 2);
            }
        }
    }
    private static void PrintOutput()
    {
        Console.WriteLine($"Matches: {matchesCount}");

        string manResult = males.Any() ? $"{string.Join(", ", males.ToArray())}" : "none";
        string womanResult = females.Any() ? $"{string.Join(", ", females.ToArray())}" : "none";

        Console.WriteLine($"Males left: {manResult}");
        Console.WriteLine($"Females left: {womanResult}");
    }
    private static int[] ReadArray()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }
}

