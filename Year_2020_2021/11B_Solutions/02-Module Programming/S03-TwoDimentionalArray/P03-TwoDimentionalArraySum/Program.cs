using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Cols: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] table = new int[rows, cols];

        ReadTwoDimensionalArray(table);

        Console.WriteLine(new string(' ',20));

        int sum = 0;

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                sum += table[i, j];
            }
        }
        Console.WriteLine($"Array sum: {sum}");
        double average = sum / (double)(rows * cols);
        Console.WriteLine($"Array average: {average}");
    }

    private static void ReadTwoDimensionalArray(int[,] matrix)
    {
        //Въвеждане стойност на елементите
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"Enter value for position [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
    private static void PrintTwoDimensionalArray(int[,] matrix)
    {
        //Отпечатване на двумерен масив
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],3} ");
            }
            Console.WriteLine();
        }
    }
}



