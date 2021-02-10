using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;

public class Program
{
    private const int glass = 25;
    private const int aluminium = 50;
    private const int lithium = 75;
    private const int carbonFiber = 100;

    private static int countGlass = 0;
    private static int countAluminium = 0;
    private static int countLithium = 0;
    private static int countCarbonFiber = 0;

    private static Queue<int> liquids;
    private static Stack<int> items;

    static void Main(string[] args)
    {
        liquids = new Queue<int>(ReadArrNums());
        items = new Stack<int>(ReadArrNums());

        while (liquids.Any() && items.Any())
        {
            Action();
        }

        bool isSpaceCraft = IsSpaceCrafted();

        PrintIsCrafted(isSpaceCraft);

        PrintLiquids();

        PrintItems();

        PrintCountMaterials();

    }

    private static bool IsSpaceCrafted()
    {
        return countAluminium > 0 && countCarbonFiber > 0 && countGlass > 0 && countLithium > 0;
    }

    private static void Action()
    {
        int mixLiquid = liquids.Peek();
        int mixItem = items.Peek();

        int sum = mixItem + mixLiquid;

        bool isCraft = true;
        isCraft = ChangeCountElements(sum, isCraft);

        mixItem = CheckCraft(mixItem, isCraft);
    }

    private static bool ChangeCountElements(int sum, bool isCraft)
    {
        switch (sum)
        {
            case glass:
                countGlass++;
                break;
            case aluminium:
                countAluminium++;
                break;
            case lithium:
                countLithium++;
                break;
            case carbonFiber:
                countCarbonFiber++;
                break;
            default:
                isCraft = false;
                break;
        }

        return isCraft;
    }

    private static int CheckCraft(int mixItem, bool isCraft)
    {
        if (isCraft)
        {
            liquids.Dequeue();
            items.Pop();
        }
        else
        {
            liquids.Dequeue();
            mixItem += 3;
            items.Pop();
            items.Push(mixItem);
        }

        return mixItem;
    }

    private static void PrintCountMaterials()
    {
        Console.WriteLine($"Aluminium: {countAluminium}");
        Console.WriteLine($"Carbon fiber: {countCarbonFiber}");
        Console.WriteLine($"Glass: {countGlass}");
        Console.WriteLine($"Lithium: {countLithium}");
    }

    private static void PrintItems()
    {
        if (items.Any())
        {
            Console.WriteLine($"Physical items left: {string.Join(", ", items)}");
        }
        else
        {
            Console.WriteLine("Physical items left: none");
        }
    }

    private static void PrintLiquids()
    {
        if (liquids.Any())
        {
            Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
        }
        else
        {
            Console.WriteLine("Liquids left: none");
        }
    }

    private static void PrintIsCrafted(bool isSpaceCraft)
    {
        if (isSpaceCraft)
        {
            Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
        }
        else
        {
            Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
        }
    }

    private static int[] ReadArrNums()
    {
        return Console.ReadLine()
              .Split(' ')
              .Select(int.Parse)
              .ToArray();
    }
}

