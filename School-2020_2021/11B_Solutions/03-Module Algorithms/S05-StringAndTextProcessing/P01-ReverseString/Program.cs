using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> words = new List<string>();

        while (true)
        {
            string word = Console.ReadLine();
            if (word=="end")
            {
                break;
            }
            words.Add(word);
        }

        foreach (var word in words)
        {
            Console.WriteLine($"{word} = {Reverse(word)}");
        }
    }

    private static string Reverse(string word)
    {
        string reversedWord = string.Empty;
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }

        return reversedWord;
    }
}

