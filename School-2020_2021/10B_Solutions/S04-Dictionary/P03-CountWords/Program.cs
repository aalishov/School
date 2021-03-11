using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> input = Console
            .ReadLine()
            .ToLower()
            .Split(' ')
            .ToList();
        Dictionary<string, int> words = new Dictionary<string, int>();

        foreach (var word in input)
        {
            if (words.ContainsKey(word))
            {
                words[word]++;
            }
            else
            {
                words.Add(word, 1);
            }
        }
        foreach (var word in words)
        {
            if (word.Value % 2 == 1)
            {
                Console.WriteLine($"{word.Key} => {word.Value}");
            }
        }
    }
}

