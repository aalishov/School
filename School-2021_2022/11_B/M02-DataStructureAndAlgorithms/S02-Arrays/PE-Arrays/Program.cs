using System;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[ReadArrayLength()];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter element [{i}]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sum: {Sum(k, arr)}");
        Console.WriteLine($"Count: {Count(arr)}");
        Console.WriteLine(string.Join(", ", arr));
    }

    public static int Count(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int element = arr[i];
            if (element >= 100 && element <= 999)
            {
                int sum = 0;
                while (element != 0)
                {
                    sum += element % 10;
                    element /= 10;
                }
                if (sum % 2 == 0)
                {
                    count++;
                }
            }
        }
        return count;
    }

    public static int Sum(int k, int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > k)
            {
                sum += arr[i];
            }
        }
        return sum;
    }
    public static int ReadArrayLength()
    {
        while (true)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());
            if (length >= 2 && length <= 50)
            {
                return length;
            }
            Console.WriteLine("Error...Number must be between [2;50]!");
        }
    }
}

