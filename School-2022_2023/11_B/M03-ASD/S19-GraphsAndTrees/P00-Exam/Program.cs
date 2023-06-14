using P01_Trees;
using System;
using System.Collections.Generic;
        
public class Program
{
    public static void Main()
    {
        Tree<string> t = new Tree<string>(
            "50",
                new Tree<string>("30"),
                new Tree<string>("40",
                    new Tree<string>(","),
                    new Tree<string>("!")
                ),
                new Tree<string>("50"),
                new Tree<string>("60",
                    new Tree<string>("A"),
                    new Tree<string>("B")
                )

            );
    }
    public static void Swap<T>(T[] elements, int first, int second)
    {
        T temp = elements[first];
        elements[first] = elements[second];
        elements[second] = temp;
    }
    public static bool IsLess(IComparable first, IComparable second)
    {
        return
            first.CompareTo(second) < 0;
    }
    public static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int min = i;
            for (int j = i+1; j <array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }            }
            Swap(array, min, i);
        }
    }
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (array[i] < array[j])
                {
                    Swap(array, i, j);
                }
            }
        }
    }
    public static int BinarySeacrh(int[] arr, int searchedValue)
    {
        int start = 0;
        int end = arr.Length-1;
        while (end>=start)
        {
            int mid = (start + end) / 2;
            if (arr[mid]>searchedValue)
            {
                end = mid - 1;
            }
            else if (arr[mid]<searchedValue)
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



}

