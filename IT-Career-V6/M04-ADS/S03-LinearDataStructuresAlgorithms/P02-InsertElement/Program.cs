using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] arr = Console.ReadLine()
             .Split(" ")
             .Select(int.Parse)
             .ToArray();

        Array.Sort(arr);

        int num = int.Parse(Console.ReadLine());

        int[] newArray = new int[arr.Length + 1];

        int insertIndex = -1;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= num)
            {
                insertIndex = i;
                break;
            }
        }

        if (insertIndex == 0)
        {
            newArray[insertIndex] = num;
            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = arr[i - 1];
            }
        }
        else if (insertIndex == -1)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            newArray[newArray.Length - 1] = num;
        }
        else
        {
            for (int i = 0; i < insertIndex; i++)
            {
                newArray[i] = arr[i];
            }
            newArray[insertIndex] = num;
            for (int i = insertIndex + 1; i < newArray.Length; i++)
            {
                newArray[i] = arr[i - 1];
            }
        }


        Console.WriteLine(string.Join(", ", arr));
        Console.WriteLine(string.Join(", ", newArray));
    }
}
