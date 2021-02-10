using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var numbers = new List<int>();
        numbers.Add(12);
        numbers.Add(0);
        numbers.Insert(0, 7);
        numbers.InsertRange(0, new int[] { 2, 7, 8 });
        Console.WriteLine(string.Join(" ",numbers));
        Console.WriteLine(numbers.FindIndex(x=>x==15));
        Console.WriteLine(numbers.FindIndex(x => x ==7));
        Console.WriteLine(numbers.Contains(15));
    }
}

