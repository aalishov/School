using System;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Action<string> print = name => Console.WriteLine("Sir " + name);

        Console.ReadLine()
            .Split(' ')
            .ToList()
            .ForEach(x => print(x));
    }
}
