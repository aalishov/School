using System;


class Program
{
    static void Main(string[] args)
    {
        string words = "Hello, string processing string with string C#! string";

        string result = words.Remove(6,5);
        string result2 = words.Remove(3, 2);
        string result3 = words.Remove(0, 5);
        string result4 = words.Remove(10);
        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.WriteLine(result4);
    }
}

