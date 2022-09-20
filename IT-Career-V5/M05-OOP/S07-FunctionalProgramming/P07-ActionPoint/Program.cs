using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        Action<string> print = name => Console.WriteLine(name);

        Console.ReadLine()
            .Split(' ')
            .ToList()
            .ForEach(x => print(x));
    }
}

