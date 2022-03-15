using System;

class Program
{
    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int[,] arr = new int[rows, cols];
        ReadArray(arr);
        PrintArray(arr);
        SumArray(arr);
        RowsSum(arr);
    }
    public static void RowsSum(int[,] array)
    {
        int sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write($"{array[row, col],5} ");
                sum += array[row, col];
            }
            Console.WriteLine($"={sum,5}");
            sum = 0;
        }
    }
    public static void SumArray(int[,] array)
    {
        int sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                sum += array[row, col];
            }
        }
        Console.WriteLine($"Array sum: {sum}");
    }

    public static void PrintArray(int[,] array)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                Console.Write($"{array[row, col],4} ");
            }
            Console.WriteLine();
        }
    }
    public static void ReadArray(int[,] array)
    {
        Random random = new Random();
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                //array[row, col] = int.Parse(Console.ReadLine());
                array[row, col] = random.Next(-500, 500);
            }
        }
    }
}

