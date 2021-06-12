using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static Queue<int> liquids;
    private static Stack<int> items;

    private static int glass = 0;
    private static int aluminium = 0;
    private static int lithium = 0;
    private static int carbon = 0;
    static void Main()
    {
        liquids = new Queue<int>(ReadInput());
        items = new Stack<int>(ReadInput());


        while (liquids.Any() && items.Any())
        {
            int currentLiquid = liquids.Dequeue();
            int currentItem = items.Pop();
            int sum = currentItem + currentLiquid;

            if (sum == 25) { glass++; }
            else if (sum == 50) { aluminium++; }
            else if (sum == 75) { lithium++; }
            else if (sum == 100) { carbon++; }
            else { items.Push(currentItem += 3); }
        }

        if (glass > 0 && aluminium > 0 && lithium > 0 && carbon > 0)
        {
            Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
        }
        else
        {
            Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
        }

        Console.WriteLine( liquids.Any() ? $"Liquids left: {string.Join(", ",liquids)}": "Liquids left: none");
        Console.WriteLine(items.Any() ? $"Physical items left: {string.Join(", ", items)}" : "Physical items left: none");

        Console.WriteLine($"Aluminium: {aluminium}");
        Console.WriteLine($"Carbon fiber: {carbon}");
        Console.WriteLine($"Glass: {glass}");
        Console.WriteLine($"Lithium: {lithium}");
    }

    public static int[] ReadInput()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }
}

