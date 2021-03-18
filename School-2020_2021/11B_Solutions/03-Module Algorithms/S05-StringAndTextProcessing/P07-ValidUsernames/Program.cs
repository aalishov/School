using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine(string.Join("\n", Console.ReadLine()
            .Split(", ")
            .ToArray()
            .Where(x => IsValidCharacters(x) && IsValidLength(x)))); 
    }
    public static bool IsValidCharacters(string s)
    {
        bool isValid = true;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (!char.IsLetterOrDigit(c) && c != '-' && c != '_')
            {
                isValid = false;
                break;
            }
        }
        return isValid;
    }
    public static bool IsValidLength(string s)
    {
        if (s.Length >= 3 && s.Length <= 16)
        {
            return true;
        }
        return false;
    }
}

