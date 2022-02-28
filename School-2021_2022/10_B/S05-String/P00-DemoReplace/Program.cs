using System;

public class Program
{
    static void Main()
    {
        string s = "Hello World!";
        string result = s.Replace("ll", "*");
        result = result.Replace("o", "*");
        Console.WriteLine($"Before: {s}");
        Console.WriteLine($"After: {result}");
    }
}

