using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

internal class Program
{
    static List<List<string>> combinations = new List<List<string>>();
    static void Main()
    {

        var data1 = Console.ReadLine().Split(" ").ToList();
        int n = int.Parse(Console.ReadLine());

        List<string> priority = Console.ReadLine().Split(" ").ToList();



        // Combination = Комбинации = O(N! / K!(N - K)!)
        Console.WriteLine("4. Combination ...");
        Combination(data1.ToArray(), n); // k = 2



        foreach (var combination in combinations)
        {

            for (int j = priority.Count - 1; j >= 0; j--)
            {
                if (combination.Any(x => x == priority[j]))
                {
                    combination.Remove(priority[j]);
                    combination.Insert(0, priority[j]);
                }
            }
        }


        foreach (var c in combinations)
        {
            Console.WriteLine(string.Join(" ", c));
        }
    }

    public static void Combination(string[] array, int k)
    {
        string[] vector = new string[k];
        CombinationAlgo(array, vector, 0, 0);
    }

    private static void CombinationAlgo(string[] array, string[] vector, int index, int start)
    {
        if (index >= vector.Length)
        {
            //Console.WriteLine(string.Join(" ", vector));
            combinations.Add(vector.ToList());
        }
        else
        {
            for (int i = start; i < array.Length; i++)
            {
                vector[index] = array[i];
                CombinationAlgo(array, vector, index + 1, i + 1);
            }
        }
    }
}

