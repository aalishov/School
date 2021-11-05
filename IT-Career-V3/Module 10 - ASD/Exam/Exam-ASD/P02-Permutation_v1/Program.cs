using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static bool hasPerm = false;
    private static List<string> results = new List<string>();
    public static void Main()
    {
        string[] symbols = Console.ReadLine().Split(' ');
        string[] permutaitons = new string[symbols.Length];
        bool[] used = new bool[symbols.Length];
        List<string> strings = new List<string>();
        string input = Console.ReadLine();
        while (input != "end")
        {
            strings.Add(input);
            input = Console.ReadLine();
        }

        GeneratePermutatiton(0, symbols, permutaitons, used, strings);
        if (!hasPerm)
        {
            Console.WriteLine("No permutations...");
        }
        foreach (var s in results.OrderBy(x => x))
        {
            Console.WriteLine(s);
        }

    }

    public static void GeneratePermutatiton(int index, string[] str, string[] perm, bool[] isUsed, List<string> strings)
    {
        if (index >= str.Length)
        {
            if (strings.Contains(string.Join("", perm)))
            {
                results.Add(string.Join(" ", perm));
                hasPerm = true;
            }
        }
        else
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!isUsed[i])
                {
                    isUsed[i] = true;
                    perm[index] = str[i];
                    GeneratePermutatiton(index + 1, str, perm, isUsed, strings);
                    isUsed[i] = false;
                }
            }
        }
    }
}