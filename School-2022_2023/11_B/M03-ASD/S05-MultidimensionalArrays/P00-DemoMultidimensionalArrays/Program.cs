using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        //int[,] arr = new int[3, 2];
        //ReadArr(arr);
        //Console.WriteLine();
        //PrintArr(arr);

        List<int> list = new List<int>() { 1,2,3};
        list[0] = 6;
    }

    public static void PrintArr(int[,] arr)
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            int sum = 0;
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                sum += arr[row, col];
                Console.Write($"{arr[row, col]} ");
            }
            Console.WriteLine($" = {sum}");
        }
    }

    public static void ReadArr(int[,] arr)
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write($"Enter element [{row} ; {col}]: ");
                arr[row, col] = int.Parse(Console.ReadLine());
            }
        }
    }
}

