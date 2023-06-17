using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<int> first = new List<int>() { 1, 2, 3, 4, 2, 5 };
        List<int> second = new List<int>() { 2, 4, 6 };

        List<int> union = Union(first, second);
        List<int> intersection = Intersection(first, second);

        Console.WriteLine($"Union: {string.Join(", ", union)}");
        Console.WriteLine($"Intersection: {string.Join(", ", intersection)}");
    }

    private static List<int> Intersection(List<int> first, List<int> second)
    {
        List<int> intersection = new List<int>();
        for (int i = 0; i < first.Count; i++)
        {
            if (second.Contains(first[i]) && !intersection.Contains(first[i]))
            {
                intersection.Add(first[i]);
            }
        }
        return intersection;
    }

    private static List<int> Union(List<int> first, List<int> second)
    {
        List<int> set = new List<int>();

        for (int i = 0; i < first.Count; i++)
        {
            if (!set.Contains(first[i]))
            {
                set.Add(first[i]);
            }
        }
        for (int i = 0; i < second.Count; i++)
        {
            if (!set.Contains(second[i]))
            {
                set.Add(second[i]);
            }
        }

        return set;
    }
}
