using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[ArrayLength()];
        SetArrayValue(arr);
        Console.WriteLine(string.Join(", ", arr));
        //Sum(arr);
        //Sum_v2(arr);
        CountNumbers(arr);
    }
    public static void CountNumbers(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            int num = arr[i];
            if (num > 99 && num < 1000 && SumDigit(num) % 2 == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Count: {count}");
    }
    public static int SumDigit(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += (num % 10);
            num /= 10;
        }
        return sum;
    }
    public static void Sum_v2(int[] arr)
    {
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        int sum = arr.Where(x => x > k).Sum();
        Console.WriteLine($"Sum: {sum}");
    }
    public static void Sum(int[] arr)
    {
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > k)
            {
                sum += arr[i];
            }
        }
        Console.WriteLine($"Sum: {sum}");
    }
    public static void SetArrayValue(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter value element[{i}]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
    }
    public static int ArrayLength()
    {
        while (true)
        {
            Console.Write("Enter array length [2;50]: ");
            int length = int.Parse(Console.ReadLine());
            if (length >= 2 && length <= 50)
            {
                return length;
            }
            Console.WriteLine("Invalid length!");
        }
    }
}

