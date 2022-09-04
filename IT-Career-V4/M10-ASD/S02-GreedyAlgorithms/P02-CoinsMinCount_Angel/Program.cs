using System;
using System.Collections.Generic;

internal class Program
{

    static void Main()
    {
        Console.WriteLine("Enter the amount: ");
        int sum = int.Parse(Console.ReadLine());
        int[] coins = new int[] { 25, 10, 5, 1 };
        List<int> chosencoins = new List<int>();
        foreach (var item in coins)
        {
            while (sum - item >= 0)
            {
                sum = sum - item;
                chosencoins.Add(item);
            }
        }
        Console.WriteLine(String.Join(", ", chosencoins));
    }
}

