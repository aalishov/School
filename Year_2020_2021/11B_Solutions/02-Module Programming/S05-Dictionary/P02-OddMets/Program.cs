using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, int> wordsCounter = new Dictionary<string, int>();
        
        //3 5 5 hi pi HO Hi 5 ho 3 hi pi

        string[] words = Console.ReadLine()
            .Split(' ')
            .Select(w => w.ToLower())
            .ToArray();

        //3 5 5 hi pi ho hi 5 ho 3 hi pi
        foreach (var word in words)
        {
            if (wordsCounter.ContainsKey(word))
            {
                wordsCounter[word]++;
            }
            else
            {
                wordsCounter.Add(word, 1);
            }
        }

        foreach (var item in wordsCounter.Where(x => x.Value % 2 == 1))
        {
            Console.Write($"{item.Key} ");
        }

        Console.WriteLine();
    }
}

