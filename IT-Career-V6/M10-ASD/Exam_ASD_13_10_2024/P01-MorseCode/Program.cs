using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> codes = new List<string>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string code = Console.ReadLine();
            codes.Add(code);
        }
        CombinationRepeat(codes, n);
    }

    public static void CombinationRepeat<T>(List<T> array, int k)
    {
        T[] vector = new T[k];
        CombinationRepeatAlgo(array, vector, 0, 0);
    }

    private static void CombinationRepeatAlgo<T>(List<T> array, T[] vector, int index, int start)
    {
        if (index >= vector.Length)
        {
            Console.WriteLine(string.Join("", vector));
        }
        else
        {
            for (int i = start; i < array.Count; i++)
            {
                vector[index] = array[i];
                CombinationRepeatAlgo(array, vector, index + 1, i);
            }
        }
    }
}