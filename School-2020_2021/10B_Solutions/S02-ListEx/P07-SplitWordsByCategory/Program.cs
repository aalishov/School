using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<string> lower = new List<string>();
    static List<string> mixed = new List<string>();
    static List<string> upper = new List<string>();

    static void Main()
    {
        char[] separators = new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']' };

        string[] words = Console.ReadLine()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        foreach (var word in words)
        {
            bool isHasLower = false;
            bool isHasUpper = false;
            bool isHasSymbol = false;

            for (int i = 0; i < word.Length; i++)
            {

                if (char.IsUpper(word[i]))
                {
                    isHasUpper = true;
                }
                //(int)word[i] >= 97 && (int)word[i] <= 122
                //(int)word[i] >= 'a' && (int)word[i] <= 'z'
                else if (char.IsLower(word[i]))
                {
                    isHasLower = true;
                }
                else if (!char.IsUpper(word[i]) && !char.IsLower(word[i]))
                {
                    isHasSymbol = true;
                }
                if (isHasUpper && isHasLower)
                {
                    break;
                }
            }

            if (isHasUpper && !isHasLower && !isHasSymbol)
            {
                upper.Add(word);
            }
            else if (isHasLower && !isHasUpper && !isHasSymbol)
            {
                lower.Add(word);
            }
            else
            {
                mixed.Add(word);
            }
        }
        Console.WriteLine($"Lower-case: {string.Join(", ", lower)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", upper)}");
    }
}

