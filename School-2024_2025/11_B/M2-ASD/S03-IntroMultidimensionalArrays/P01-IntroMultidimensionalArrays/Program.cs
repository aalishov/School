public class Program
{
    public static void Main(string[] args)
    {
        int[,] nums = new int[7, 5];

        int rowsCount = int.Parse(Console.ReadLine());
        int colsCount = int.Parse(Console.ReadLine());

        int[,] matrix = CreateMatrix(rowsCount, colsCount);
        int[] row = { 1, 2, 2 };

        Console.WriteLine($"Rows count: {matrix.GetLength(0)}");
        Console.WriteLine($"Cols count: {matrix.GetLength(1)}");
        Console.WriteLine($"Length: {matrix.Length}");
        Console.WriteLine($"Sum = {GetSum(matrix)}");
        Console.WriteLine($"Max = {GetMax(matrix)}");
        Console.WriteLine($"Min = {GetMin(matrix)}");
        Console.WriteLine($"Sum main diagonal = {GetSumMainDiagonal(matrix)}");
        PrintMatrix(matrix);
    }
    private static int GetSumMainDiagonal(int[,] matrix)
    {
        int sum = 0;

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (rows == cols)
                {
                    sum += matrix[rows, cols];
                }
            }
        }
        return sum;
    }

    private static int GetMin(int[,] matrix)
    {
        int max = int.MaxValue;

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (matrix[rows, cols] < max)
                {
                    max = matrix[rows, cols];
                }
            }
        }

        return max;
    }

    private static int GetMax(int[,] matrix)
    {
        int max = int.MinValue;

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (matrix[rows, cols] > max)
                {
                    max = matrix[rows, cols];
                }
            }
        }

        return max;
    }

    private static int GetSum(int[,] matrix)
    {
        int sum = 0;

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                sum += matrix[rows, cols];
            }
        }

        return sum;
    }

    private static int[,] CreateMatrix(int rowsCount, int colsCount)
    {
        int[,] matrix = new int[rowsCount, colsCount];
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                matrix[rows, cols] = new Random().Next(-100, 100);
            }
        }

        return matrix;
    }

    private static void PrintMatrix(int[,] nums)
    {
        for (int rows = 0; rows < nums.GetLength(0); rows++)
        {
            for (int cols = 0; cols < nums.GetLength(1); cols++)
            {
                Console.Write($"{nums[rows, cols],3} ");
            }
            Console.WriteLine();
        }
    }
}