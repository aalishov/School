using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var arr1 = new int[5] { 5, -2, 3, 0, 0 };
        arr1[1] += 12;

        var arr2 = new int[2, 3];

        var arr3 = new int[2, 3, 2];

        var isNum = false;

        Console.WriteLine(string.Join(", ", arr1));
        Array.Sort(arr1);
        Console.WriteLine($"Array.Sort() => {string.Join(", ", arr1)}");
        Console.WriteLine($"Linq=> {string.Join(", ", arr1.OrderByDescending(x => x))}");
        Console.WriteLine($"After linq=> {string.Join(", ", arr1)}");
        Console.WriteLine(arr1.Length);
    }
}

