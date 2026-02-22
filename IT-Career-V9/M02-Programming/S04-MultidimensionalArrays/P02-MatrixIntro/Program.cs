public class Program
{
    public static void Main()
    {

        int rowsCount = 3;
        int colsCount = 5;
        int[,] matrix = new int[rowsCount, colsCount];

        ReadMatrix(matrix);

        PrintMatrixColored(matrix);

        ArrayStatistics(matrix);
    }

    private static void ArrayStatistics(int[,] matrix)
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int current = matrix[row, col];
                if (current > max) { max = current; }
                if (current < min) { min = current; }
                sum += current;
            }
        }
        double average = (double)sum / matrix.Length;
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average {average:f2}");
    }

    private static void PrintMatrixColored(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (row == col) { Console.ForegroundColor = ConsoleColor.DarkRed; }
                else if (row < col) { Console.ForegroundColor = ConsoleColor.DarkGreen; }
                else if (row > col) { Console.ForegroundColor = ConsoleColor.DarkYellow; }
                Console.Write($"{matrix[row, col],3} ");

                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write($"{matrix[row, col],3} ");
            }
            Console.WriteLine();
        }
    }

    private static void ReadMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = new Random().Next(-50, 50);
            }
        }
    }
}

