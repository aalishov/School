using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Dictionary<string, int> arr = new Dictionary<string, int>();
        arr.Add("Ivan", 3);
        arr.Add("Denis", 4);
        arr.Add("Jane", 0);
        var r = arr.Remove("Denis");
        Console.WriteLine(r);

        string name = Console.ReadLine();
        if (arr.ContainsKey(name))
        {
            arr[name] += 5;
        }
        else
        {
            arr.Add(name, 5);
        }


        Console.WriteLine($"Count: {arr.Count}");
        Console.WriteLine($"Key: {string.Join(", ", arr.Keys)}");
        Console.WriteLine($"Value: {string.Join(", ", arr.Values)}");

    }
}

