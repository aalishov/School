using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        List<string> names = Console.ReadLine()
            .Split(", ")
            .ToList();
        for (int i = 0; i < names.Count; i++)
        {
            string[] name = names[i].Split(" ");
            Array.Reverse(name);
            //name = name.Reverse().ToArray();
            Console.WriteLine(string.Join(" ", name));
        }
    }
}

