using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> banned = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        string result = Console.ReadLine();

        foreach (var word in banned)
        {
            result = result.Replace(word, new string('*', word.Length));
        }
        Console.WriteLine(result);
    }
}

