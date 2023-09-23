using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        int backpackWeight = 10;

        Item[] items = { new Item(7, 42), new Item(3, 12), new Item(4, 40), new Item(5, 25) };

        List<Backpack> backpacks = new List<Backpack>();

        var subsets = CreateSubsets<Item>(items);
        foreach (var set in subsets)
        {
            Backpack newBackpack = new Backpack();
            foreach (var bag in set)
            {
                newBackpack.Add(bag);
            }
            backpacks.Add(newBackpack);
        }

        foreach (var backpack in backpacks.OrderBy(x => x.Weight))
        {
            Console.WriteLine(backpack);
        }
        Console.WriteLine($"Max: {backpacks.Where(x => x.Weight <= backpackWeight).OrderBy(x => x.Price).LastOrDefault()}");
    }

    public static List<T[]> CreateSubsets<T>(T[] originalArray)
    {
        List<T[]> subsets = new List<T[]>();

        for (int i = 0; i < originalArray.Length; i++)
        {
            int subsetCount = subsets.Count;
            subsets.Add(new T[] { originalArray[i] });

            for (int j = 0; j < subsetCount; j++)
            {
                T[] newSubset = new T[subsets[j].Length + 1];
                subsets[j].CopyTo(newSubset, 0);
                newSubset[newSubset.Length - 1] = originalArray[i];
                subsets.Add(newSubset);
            }
        }
        return subsets;
    }
}

