public class Program
{
    public static void Main(string[] args)
    {
        int[,] nums = new int[4, 4];

        int rowsCount = nums.GetLength(0);
        int colsCount = nums.GetLength(1);
        int length = nums.Length;

        Console.WriteLine($"Rows count: {rowsCount}");
        Console.WriteLine($"Cols count: {colsCount}");
        Console.WriteLine($"Length: {length}");

        ReadMatrix(nums);

        PrintMatrix(nums);

        List<int> diagonal = GetMainDiagonal(nums);

        Console.WriteLine($"Sum: {diagonal.Sum()}");

        Console.WriteLine($"Diagonal => {string.Join(", ", diagonal)}");

        List<int> maxElementsByRows = GetMaxElementsByRows(nums);

        List<int> maxElementsByCols = GetMaxElemensByCols(nums);

        Console.WriteLine($"Max elements by rows: {string.Join(", ", maxElementsByRows)}");
        Console.WriteLine($"Max elements by cols: {string.Join(", ", maxElementsByCols)}");
    }

    private static List<int> GetMaxElemensByCols(int[,] nums)
    {
        List<int> maxElementsByCols = new List<int>();
        for (int cols = 0; cols < nums.GetLength(1); cols++)
        {
            int max = int.MinValue;
            for (int rows = 0; rows < nums.GetLength(0); rows++)
            {
                if (nums[rows, cols] > max)
                {
                    max = nums[rows, cols];
                }
            }
            maxElementsByCols.Add(max);
        }

        return maxElementsByCols;
    }

    private static List<int> GetMaxElementsByRows(int[,] nums)
    {
        List<int> maxElements = new List<int>();
        for (int rows = 0; rows < nums.GetLength(0); rows++)
        {
            int max = int.MinValue;
            for (int cols = 0; cols < nums.GetLength(1); cols++)
            {
                if (nums[rows, cols] > max)
                {
                    max = nums[rows, cols];
                }
            }
            maxElements.Add(max);
        }

        return maxElements;
    }

    private static List<int> GetMainDiagonal(int[,] nums)
    {
        //int[] diagonal = null;
        //if (rowsCount > colsCount)
        //{
        //    diagonal = new int[nums.GetLength(1)];
        //}
        //else
        //{
        //    diagonal = new int[nums.GetLength(0)];
        //}

        List<int> diagonal = new List<int>();

        for (int rows = 0; rows < nums.GetLength(0); rows++)
        {
            for (int cols = 0; cols < nums.GetLength(1); cols++)
            {
                if (rows == cols)
                {
                    //diagonal[rows] = nums[rows, cols];
                    diagonal.Add(nums[rows, cols]);
                }
            }
        }

        return diagonal;
    }

    private static void ReadMatrix(int[,] nums)
    {
        for (int rows = 0; rows < nums.GetLength(0); rows++)
        {
            for (int cols = 0; cols < nums.GetLength(1); cols++)
            {
                nums[rows, cols] = new Random().Next(0, 99);
            }
        }
    }

    private static void PrintMatrix(int[,] nums)
    {
        for (int rows = 0; rows < nums.GetLength(0); rows++)
        {
            for (int cols = 0; cols < nums.GetLength(1); cols++)
            {
                Console.Write($"{nums[rows, cols],3}");
            }
            Console.WriteLine();
        }
    }
}

