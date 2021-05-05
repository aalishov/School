using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = new int[] { 5, 8, 2};
        Console.WriteLine(string.Join(" ", arr));
        Console.WriteLine(arr.Length); //3
        Console.WriteLine(arr.Sum()); //15
        Console.WriteLine(arr.Min()); //2
        Console.WriteLine(arr.Max()); //8
        Console.WriteLine(arr.Average()); //5
    }
}

