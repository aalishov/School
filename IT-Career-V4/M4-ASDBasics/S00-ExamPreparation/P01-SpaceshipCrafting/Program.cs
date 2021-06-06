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
            else
            {
                items.Push(currentItem += 3);
            }
        }
    }

    public static int[] ReadInput()
    {
        return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    }
}

