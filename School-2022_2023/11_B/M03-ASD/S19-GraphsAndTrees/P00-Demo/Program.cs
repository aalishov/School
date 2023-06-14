using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        int[] elements = { 5, 10, 15, 20, 25, 30 };
        Console.WriteLine(BinarySearch(elements, 10));
    }
    public static int MinValue(int[] arr)
    {
        int n = arr.Length;
        int min = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }
    public static int MaxValue(int[] arr)
    {
        int n = arr.Length;
        int max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }


    public static int BinarySearch(int[] arr, int target)
    {
        int start = 0;
        int end = arr.Length - 1;

        while (start <= end)
        {
            int mid = (start + end) / 2;
            if (arr[mid] == target)
            {
                return mid;
            }
            else if (arr[mid] < target)
            {
                start = mid + 1;
            }
            else if (arr[mid] > target)
            {
                end = mid - 1;
            }
        }

        return -1;
    }
}

