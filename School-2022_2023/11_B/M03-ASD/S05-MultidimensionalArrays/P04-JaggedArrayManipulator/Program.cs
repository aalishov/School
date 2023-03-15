using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[][] arr = new int[n][];

        ReadArray(arr);
        Analyzing(arr);
        ExecuteCommands(arr);
        PrintArray(arr);
        Console.WriteLine();
    }

    private static void ExecuteCommands(int[][] arr)
    {
        string[] command = Console.ReadLine().Split(' ');
        while (command[0] != "End")
        {
            int specifiedRow = 0;
            int specifiedCol = 0;
            switch (command[0])
            {
                case "Add":
                    specifiedRow = int.Parse(command[1]);
                    specifiedCol = int.Parse(command[2]);

                    if (specifiedRow >= 0 && specifiedRow < arr.GetLength(0))
                    {
                        if (specifiedCol >= 0 && specifiedCol < arr[specifiedRow].Length)
                        {
                            arr[specifiedRow][specifiedCol] += int.Parse(command[3]);
                        }
                    }
                    break;
                case "Subtract":
                    specifiedRow = int.Parse(command[1]);
                    specifiedCol = int.Parse(command[2]);

                    if (specifiedRow >= 0 && specifiedRow < arr.GetLength(0))
                    {
                        if (specifiedCol >= 0 && specifiedCol < arr[specifiedRow].Length)
                        {
                            arr[specifiedRow][specifiedCol] -= int.Parse(command[3]);
                        }
                    }
                    break;
            }
            PrintArray(arr);
            Console.WriteLine();
            command = Console.ReadLine().Split(' ');
        }
    }

    private static void Analyzing(int[][] arr)
    {
        for (int row = 0; row < arr.GetLength(0) - 1; row++)
        {
            if (arr[row].Length == arr[row + 1].Length)
            {
                for (int i = 0; i < arr[row].Length; i++)
                {
                    arr[row][i] *= 2;
                    arr[row + 1][i] *= 2;
                }
            }
            else
            {
                for (int i = 0; i < arr[row].Length; i++)
                {
                    arr[row][i] /= 2;
                }
                for (int i = 0; i < arr[row + 1].Length; i++)
                {
                    arr[row + 1][i] /= 2;
                }
            }
            PrintArray(arr);
            Console.WriteLine();
        }
    }

    public static void PrintArray(int[][] arr)
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr[row].Length-1; col++)
            {
                Console.Write($"{arr[row][col],4}, ");
            }
            Console.Write($"{arr[row][arr[row].Length - 1],4}");
            Console.WriteLine();
        }
    }
    public static void ReadArray(int[][] arr)
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            arr[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}

