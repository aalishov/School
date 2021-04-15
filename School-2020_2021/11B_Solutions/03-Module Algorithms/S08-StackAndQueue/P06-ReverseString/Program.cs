using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Stack<char> s = new Stack<char>();
        string input = Console.ReadLine();
        foreach (var c in input)
        {
            s.Push(c);
        }

        while (s.Any())
        {
            Console.Write(s.Pop());
        }
        Console.WriteLine();
    }
}

