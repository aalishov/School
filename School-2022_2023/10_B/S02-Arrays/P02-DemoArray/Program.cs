using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        //5 10 15 20 30
        int[] numbers=Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(String.Join(" | ",numbers));
    }
}

