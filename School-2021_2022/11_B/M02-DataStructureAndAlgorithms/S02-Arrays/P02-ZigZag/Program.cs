using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] first = new int[n];
        int[] second = new int[n];
        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            if (i % 2 == 0)
            {
                first[i] = input[0];
                second[i] = input[1];
            }
            else
            {
                first[i] = input[1];
                second[i] = input[0];
            }
        }
        Console.WriteLine(string.Join(" ",first));
        Console.WriteLine(string.Join(" ", second));
    }
}

