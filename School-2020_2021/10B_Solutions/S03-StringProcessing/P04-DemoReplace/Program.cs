using System;

class Program
{
    static void Main(string[] args)
    {
        string words = "Hello, string processing string with string C#! string";
        string match = "string";
        string replace = "*****";
        string result = words.Replace(match, replace);
        Console.WriteLine(words);
        Console.WriteLine(result);
    }
}

