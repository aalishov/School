using System;

class Program
{
    public static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        int[,] arr = new int[rows, cols];
        ReadArray(arr);
        //PrintArray(arr);
        //SumArray(arr);
        RowsSum(arr);
        //CountEvenOddNums(arr);
        //CountPossitiveNegative(arr);
        ColsSum(arr);
        SumBetweemDiagonal(arr);
    }
    public static void CountPossitiveNegative(int[,] array)
    {
        int possitive = 0;
        int negative = 0;
        int zero = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (array[row, col] > 0)
                {
                    possitive++;
                }
                else if (array[row, col] < 0)
                {
                    negative++;
                }
                else if (array[row, col] == 0)
                {
                    zero++;
                }
            }
        }
        Console.WriteLine($"The count of the possitive numbers is: {possitive}");
        Console.WriteLine($"The count of the negative numbers is: {negative}");
        Console.WriteLine($"The count of the zeros is: {zero}");
    }

    public static void CountEvenOddNums(int[,] array)
    {
        int oddNums = 0;
        int evenNums = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (array[row, col] % 2 == 0)
                {
                    evenNums++;
                }
                else
                {
                    oddNums++;
                }
            }
        }
        Console.WriteLine($"The count of the even numbers in the array is {evenNums}");
        Console.WriteLine($"The count of the odd numbers in the array is {oddNums}");
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
                array[row, col] = random.Next(0, 20);
            }
        }
    }
    public static void ColsSum(int[,] array)
    {
        string line = string.Empty;
        string result = string.Empty;
        int sum = 0;
        for (int col = 0; col < array.GetLength(1); col++)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                sum += array[row, col];
            }
            line += $"{new string('_', sum.ToString().Length),5} ";
            result += $"{sum,5} ";
            sum = 0;
        }
        Console.WriteLine(line);
        Console.WriteLine(result);
    }

    public static void SumBetweemDiagonal(int[,] array)
    {
        int sumUpper = 0;
        int sumLower = 0;
        int sumMainDiagonal = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            { 
                if (row < col)  {
                    sumUpper += array[row, col];}
                else if (col<row) {
                    sumLower += array[row, col]; }
                else { sumMainDiagonal += array[row, col]; }
            }
        }
        Console.WriteLine($"The Sum of:");
        Console.WriteLine($"Main Diagonal: {sumMainDiagonal}");
        Console.WriteLine($"Upper Part: {sumUpper}");
        Console.WriteLine($"Lower Part: {sumLower}");
    }
}

