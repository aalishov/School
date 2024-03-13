using System.Linq;
public class Program
{
    public static void Main()
    {
        int[,] nums = CreateRandomArray();
        PrintArray(nums);

        int secondMax = GetSecondMax(nums);
        Console.WriteLine($"Second max: {secondMax}");
    }

    private static int GetSecondMax(int[,] nums)
    {
        List<int> list = new List<int>();

        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                list.Add(nums[i, j]);
            }
        }

        return list
            .OrderByDescending(x => x)
            .ToList()[1];
    }

    public static void PrintArray(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j],4}");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateRandomArray()
    {
        int m = new Random().Next(2, 8);
        int n = new Random().Next(2, 8);

        int[,] arr = new int[m, n];

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(-50, 50);
            }
        }

        return arr;
    }
}