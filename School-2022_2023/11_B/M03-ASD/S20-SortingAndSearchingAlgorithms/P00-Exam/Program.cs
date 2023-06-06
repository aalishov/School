using System;

public class Program
{
    public static void Main()
    {
        int[] ints = {-7,0,15,9,100,3,-4,89,-4,0,24};
        BubbleSort(ints);
        Console.WriteLine(string.Join(" ",ints));
    }
    public static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i]==target)
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
            for (int j = i+1; j < arr.Length; j++)
            {
                if (arr[min] > arr[j])
                {
                   min = j;
                }
            }
            Swap(arr, min, i);
        }
    }
    public static void BubbleSort(int[]arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < arr.Length-1; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    Swap(arr, j,j+1);
                }
            }
        }
    }
}


