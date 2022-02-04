using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = ReadArr();

        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine($"Product: {Prod(k, arr)}");
        PrintElementsBetween100And666(arr);
    }

    public static void PrintElementsBetween100And666(int[] arr)
    {
        int[] newArr = arr.Where(x => x >= 100 & x <= 666)
            .OrderBy(x=>x)
            .ToArray();
        Console.WriteLine($"Elementrs between 100 and 666: {string.Join(" ", newArr)}");
    }

    public static int Prod(int k, int[] arr)
    {
        int product = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0 && arr[i] < k)
            {
                product *= arr[i];
            }
        }
        return product;
    }
    public static int[] ReadArr()
    {
        int num = 0;
        while (num < 2 || num > 25)
        {
            Console.Write("Enter array length: ");
            num = int.Parse(Console.ReadLine());
        }

        int[] arr = new int[num];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter element: [{i}] ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        return arr;
    }
}


