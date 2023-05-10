using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<char> letters = new List<char>();
        List<char> digits = new List<char>();
        List<char> otherSymbols = new List<char>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 'a' && input[i]<='z' || input[i] >= 'A' && input[i] <= 'Z') //char.IsLetter(input[i])
            {
                letters.Add(input[i]);
            }
            else if (input[i] >= '0' && input[i] <= '9') //char.IsDigit(input[i])
            {
                digits.Add(input[i]);
            }
            else
            {
                otherSymbols.Add(input[i]);
            }
        }
        Console.WriteLine(string.Join("",letters));
        Console.WriteLine(string.Join("", digits));
        Console.WriteLine(string.Join("", otherSymbols));
    }
}

