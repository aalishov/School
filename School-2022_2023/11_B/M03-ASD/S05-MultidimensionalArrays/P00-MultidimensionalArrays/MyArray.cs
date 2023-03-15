using System;
using System.Collections.Generic;
using System.Text;

public static class MyArray
{
    public static string PrintArray(int[,] array, string separator = ", ")
    {
        StringBuilder sb = new StringBuilder();
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int colum = 0; colum < array.GetLength(1) - 1; colum++)
            {
                sb.Append($"{array[row, colum],4}");
                sb.Append(separator);
            }
            sb.Append($"{array[row, array.GetLength(1) - 1],4}");
            sb.AppendLine();
        }
        return sb.ToString();
    }
    public static int[,] RandomArray(int rows, int colums, int min, int max)
    {
        int[,] array = new int[rows, colums];
        Random random = new Random();
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                array[row, col] = random.Next(min, max);
            }
        }
        return array;
    }
    public static int Sum(int[,] array)
    {
        int sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                sum += array[row, col];
            }
        }
        return sum;
    }
    public static int SumDiagonal(int[,] array)
    {
        int sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (row == col)
                {
                    sum += array[row, col];
                }
            }
        }
        return sum;
    }
    public static int AboveDiagonal(int[,] array)
    {
        int sum = 0;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (row < col)
                {
                    sum += array[row, col];
                }
            }
        }
        return sum;
    }
    public static int MaxElement(int[,]array)
    {
        int max = int.MinValue;
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (array[row,col]>max)
                {
                    max = array[row, col];
                }
            }
        }
        return max;
    }
    public static int GetSecondLargestElement(int[,]arr)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if (arr[row,col]>largest)
                {
                    largest = arr[row, col];
                }
            }
        }
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if (arr[row, col] > secondLargest && largest > arr[row, col])
                {
                    secondLargest = arr[row, col];
                }
            }
        }
        return secondLargest;
    }
}


