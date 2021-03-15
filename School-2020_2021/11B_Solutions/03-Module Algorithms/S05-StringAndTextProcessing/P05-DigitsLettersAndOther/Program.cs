using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<char> digits = new List<char>();
        List<char> letters = new List<char>();
        List<char> other = new List<char>();

        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            char c = word[i];

            if (char.IsDigit(c))
            {
                digits.Add(c);
            }
            else if (char.IsLetter(c))
            {
                letters.Add(c);
            }
            else
            {
                other.Add(c);
            }
        }
        Console.WriteLine("Digits: "+string.Join("",digits));
        Console.WriteLine("Letters: " + string.Join("", letters));
        Console.WriteLine("Other: " + string.Join("", other));
    }
}

