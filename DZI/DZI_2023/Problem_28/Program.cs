using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static List<Furniture> furnitures = new List<Furniture>();

    public static void Main()
    {
        while (true)
        {
            string[] input = Console.ReadLine().Split(" ");

            string cmd = input[0];

            switch (cmd)
            {
                case "table":
                    furnitures.Add(new Table(double.Parse(input[1])));
                    break;
                case "cabinet":
                    furnitures.Add(new Cabinet(double.Parse(input[1]), int.Parse(input[2])));
                    break;
                case "END":
                    furnitures
                        .GroupBy(x=>x.TypeProduct)
                        .ToList()
                        .ForEach(x => Console.WriteLine($"All {x.Key}s: \n{string.Join("\n\r",x)}"));
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}

