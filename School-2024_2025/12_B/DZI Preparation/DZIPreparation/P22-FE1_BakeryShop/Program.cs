using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Dictionary<string, int> stok = new Dictionary<string, int>();
        int count = 0;
        while (true)
        {
            string[] input = Console.ReadLine().Split(" ").ToArray();
            string cmd = input[0];
            switch (cmd)
            {
                case "Receive":

                    int quantity = int.Parse(input[1]);
                    string food = input[2];
                    if (!stok.ContainsKey(food))
                    {
                        if (quantity > 0)
                        {
                            stok.Add(food, quantity);
                        }
                    }
                    break;
                case "Sell":
                    quantity = int.Parse(input[1]);
                    food = input[2];
                    if (!stok.ContainsKey(food))
                    {
                        Console.WriteLine($"You do not have any {food}.");
                    }
                    else if (quantity > stok[food])
                    {
                        Console.WriteLine($"There aren't enough {food}. You sold the last {stok[food]} of them.");
                        count += stok[food];
                        stok.Remove(food);
                    }
                    else
                    {
                        Console.WriteLine($"You sold {quantity} {food}.");
                        count += quantity;
                        stok[food] -= quantity;
                        if (stok[food] == 0)
                        {
                            stok.Remove(food);
                        }
                    }
                    break;
                case "Complete":
                    foreach (var item in stok)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                    Console.WriteLine($"All sold: {count} goods");
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
