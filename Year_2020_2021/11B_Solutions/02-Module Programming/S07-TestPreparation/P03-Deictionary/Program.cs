using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var pairs = new Dictionary<string, string>();
        pairs.Add("1", "one");
        pairs.Add("first", "one");
        pairs.Add("second", "two");
        pairs.Add("car", "red");

        pairs["red"] = "blue";
        Console.WriteLine(pairs["1"]);
        Console.WriteLine(pairs["first"]);
        Console.WriteLine(pairs.ContainsKey("2"));
        Console.WriteLine(pairs.ContainsValue("two"));

        foreach (var element in pairs)
        {
            Console.WriteLine($"{element.Key} => {element.Value}");
        }
    }
}

