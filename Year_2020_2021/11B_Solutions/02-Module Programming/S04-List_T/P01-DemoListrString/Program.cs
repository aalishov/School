using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] wordArray = new string[] { "one", "play", "write" };
        List<string> words = new List<string>(wordArray) ;

        words.Add("read");
        words.Insert(0, "go");
        words.Insert(2, "two");

        Console.WriteLine(string.Join(", ", wordArray));
        Console.WriteLine(string.Join(", ",words));
        Console.WriteLine($"List count: {words.Count}");

        Console.WriteLine(words.Remove("two"));
        Console.WriteLine(string.Join(", ", words));
        Console.WriteLine($"List count: {words.Count}");

        foreach (var word in words)
        {
            Console.WriteLine($"{word.ToUpper()} => {word.Length}");
        }
    }
}

