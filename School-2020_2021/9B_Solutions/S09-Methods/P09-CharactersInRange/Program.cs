using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Characters('a', 'z'));
    }

    public static string Characters(char first, char second)
    {
        int start = Math.Min(first, second);
        int end = Math.Max(first, second);

        string result = string.Empty;

        for (int i = start + 1; i < end; i++)
        {
            result += (char)i + " ";
        }

        return result;
    }
}

