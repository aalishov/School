using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> w = new List<string>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string element = Console.ReadLine();
            w.Add(element);
        }

        Console.WriteLine(string.Join(" | ",w));
    }
}

