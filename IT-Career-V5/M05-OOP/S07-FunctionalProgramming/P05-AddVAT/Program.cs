using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        Console.ReadLine()
            .Split(", ")
            .Select(x => double.Parse(x))
            .Select(x => x * 1.2)
            .ToList()
            .ForEach(x => Console.WriteLine($"{x:f2}"));
    }
}

