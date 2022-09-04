using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        int sum = 48;
        int[] coins = new int[] { 25, 25, 25, 10, 10, 10, 5, 5, 5, 1, 1, 1 };
        List<int> chosencoins = new List<int>();
        foreach (var item in coins)
        {
            if (sum - item >= 0)
            {
                sum = sum - item;
                chosencoins.Add(item);
            }
        }
        Console.WriteLine(String.Join(", ", chosencoins));
    }
}