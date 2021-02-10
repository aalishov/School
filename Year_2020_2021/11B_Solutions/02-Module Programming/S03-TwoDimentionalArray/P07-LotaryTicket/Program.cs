using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] info = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int row = info[0];
        int col = info[1];

        int[,] table = new int[row, col];

        ReadArrayElements(table);

        int sumMainDiagonal = 0;
        int sumSecondaryDiagonal = 0;
        int sumAboveMainDiagonal = 0;
        int sumUnderMainDiagonal = 0;

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                if (i > j)
                {
                    sumUnderMainDiagonal += table[i, j];
                }
                else if (i == j)
                {
                    sumMainDiagonal += table[i, j];
                }
                else
                {
                    sumAboveMainDiagonal = table[i, j];
                }

                if (i + j == table.GetLength(0) - 1)
                {
                    sumSecondaryDiagonal += table[i, j];
                }

            }
        }

        Console.WriteLine($"Main - {sumMainDiagonal}");
        Console.WriteLine($"Secondary = {sumSecondaryDiagonal}");

        if (sumMainDiagonal == sumSecondaryDiagonal)
        {
            Console.WriteLine("YES");
        }

        PrintArray(table);

    }

    private static void PrintArray(int[,] table)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                Console.Write($"{table[i, j],4} ");
            }
            Console.WriteLine();
        }
    }

    private static void ReadArrayElements(int[,] table)
    {
        for (int i = 0; i < table.GetLength(0); i++)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = nums[j];
            }
        }
    }
}

