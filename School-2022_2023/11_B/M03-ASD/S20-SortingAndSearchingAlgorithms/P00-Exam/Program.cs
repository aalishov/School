using System;

public class Program
{
    public static void Main()
    {
        int[] ints = { 6, 5 };
        double result = Average(ints);
        Console.WriteLine(result);
    }
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
    public static void Swap(int[] arr, int first, int second)
    {
        int temp = arr[first];
        arr[first] = arr[second];
        arr[second] = temp;
    }
    public static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[min] > arr[j])
                {
                    min = j;
                }
            }
            Swap(arr, min, i);
        }
    }
    public static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    Swap(arr, j, j + 1);
                }
            }
        }
    }
    public static int Binary<T>(T[] elements, T key) where T : IComparable
    {
        int start = 0;
        int end = elements.Length - 1;

        while (end >= start)
        {
            int mid = (start + end) / 2;

            if (elements[mid].CompareTo(key) > 0)
            {
                end = mid - 1;
            }
            else if (elements[mid].CompareTo(key) < 0)
            {
                start = mid + 1;
            }
            else
            {
                return mid;
            }
        }
        return -1;
    }

    public static int Min(int[] arr)
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
    public static int Max(int[] arr)
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

    public static double Average(int[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum / arr.Length;
    }
}


