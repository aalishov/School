using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        var costs = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var minFuel = CalculateMinFuelCost(costs);
        Console.WriteLine(minFuel);
    }

    public static int CalculateMinFuelCost(List<int> costs)
    {
        var numCities = costs.Count;
        var minCosts = new List<int>(new int[numCities]);

        for (var cityIndex = 0; cityIndex < numCities; cityIndex++)
        {
            if (cityIndex == 0 || cityIndex == 1)
            {
                minCosts[cityIndex] = costs[cityIndex];
            }
            else
            {
                minCosts[cityIndex] = Math.Min(minCosts[cityIndex - 1], minCosts[cityIndex - 2]) + costs[cityIndex];
            }
        }

        return Math.Min(minCosts[numCities - 1], minCosts[numCities - 2]);
    }
}

