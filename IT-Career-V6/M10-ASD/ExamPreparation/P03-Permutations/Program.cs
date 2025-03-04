using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    static List<int[]> matrix = new List<int[]>();
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        PermuteNoRepeat(nums, 0);

        List<int> result = new List<int>();

        foreach (var row in matrix)
        {
            int counter = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (row[i] > row[i + 1]) { counter++; }
            }
            if (counter % 2 == 0 && counter > 0)
            {
                result.Add(int.Parse(string.Join("", row)));
            }
        }

        result = result.OrderBy(x => x).ToList();

        foreach (var item in result)
        {
            Console.WriteLine(string.Join(" ", item.ToString().ToCharArray()));
        }
    }

    public static void PermuteNoRepeat<T>(T[] array, int index)
    {
        T[] vector = new T[array.Length];
        bool[] used = new bool[array.Length];
        PermuteNoRepeatAlgo(array, vector, used, index);
    }

    private static void PermuteNoRepeatAlgo<T>(T[] array, T[] vector, bool[] used, int index)
    {
        if (index >= vector.Length)
        {
            matrix.Add((int[])vector.Clone());
            //Console.WriteLine(string.Join(" ", vector));
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!used[i])
                {
                    used[i] = true;
                    vector[index] = array[i];
                    PermuteNoRepeatAlgo(array, vector, used, index + 1);
                    used[i] = false;
                }
            }
        }
    }
}

