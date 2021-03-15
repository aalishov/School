using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        List<string> words = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        StringBuilder sb = new StringBuilder();

        foreach (var word in words)
        {
            for (int i = 0; i < word.Length; i++)
            {
                sb.Append(word);
            }
        }
        Console.WriteLine(sb.ToString());
    }
}

