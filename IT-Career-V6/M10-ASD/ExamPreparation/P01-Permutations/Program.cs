
using System.Collections;
using System.Collections.Generic;

public class Program
{
    static List<int[]> matrix = new List<int[]>();
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = Enumerable.Range(1, n).ToArray();

        PermuteNoRepeat(nums, 0);

        foreach (var row in matrix)
        {
            Console.WriteLine(string.Join(", ", row));
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

