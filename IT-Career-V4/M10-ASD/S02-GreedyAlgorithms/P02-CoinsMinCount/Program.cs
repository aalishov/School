using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        int finalSum = int.Parse(Console.ReadLine());
        Dictionary<int, int> coins = new Dictionary<int, int>() { { 1, 0 }, { 5, 0 }, { 10, 0 }, { 25, 0 } };

        while (finalSum > 0)
        {
            if (finalSum % 25 == 0)
            {
                finalSum -= 25;
                coins[25]++;
            }
            else if (finalSum % 10 == 0)
            {
                finalSum -= 10;
                coins[10]++;
            }
            else if (finalSum % 5 == 0)
            {
                finalSum -= 5;
                coins[5]++;
            }
            else 
            {
                finalSum -= 1;
                coins[1]++;
            }
        }

        foreach (var coin in coins)
        {
            Console.WriteLine($"{coin.Key} => {coin.Value}");
        }
    }
}

