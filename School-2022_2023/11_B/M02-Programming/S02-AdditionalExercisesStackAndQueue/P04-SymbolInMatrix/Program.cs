using System;

public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char[,] arr = new char[n, n];

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            char[] charRow = Console.ReadLine().ToCharArray();
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                arr[row, col] = charRow[col];
            }
        }

        char symbol = char.Parse(Console.ReadLine());

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if (arr[row, col] == symbol)
                {
                    Console.WriteLine($"({row}, {col})");
                    Environment.Exit(0);
                }
            }
        }

        Console.WriteLine($"{symbol} does not occur in the matrix");
    }
}

