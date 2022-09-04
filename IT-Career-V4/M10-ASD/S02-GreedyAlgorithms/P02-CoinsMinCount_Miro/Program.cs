using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        List<int> coin = new List<int> { 25, 10, 5, 1 };

        int moneyInput = int.Parse(Console.ReadLine());

        List<int> moneyOutput = new List<int>();


        foreach (var item in coin)
        {
            while (moneyInput >= item)
            {
                if (moneyInput - item >= 0)
                {
                    moneyOutput.Add(item);
                    moneyInput -= item;
                }
            }

        }

        var g = moneyOutput.GroupBy(i => i);

        foreach (var grp in g)
        {
            Console.WriteLine("{0} - {1} coin", grp.Key, grp.Count());
        }
    }
}

