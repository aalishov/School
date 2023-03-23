using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[]array=Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int[,] arr = new int[array[0],array[1]];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int[] ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = ints[j];                
            }
        }

        int[] sum= new int[arr.GetLength(1)];

        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < arr.GetLength(0); j++)
            {
                sum[i] += arr[j, i];
            }
            
        }

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j],4}");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < sum.Length; i++)
        {
            Console.Write($"{sum[i],4}");
        }
        Console.WriteLine();

    }
}

