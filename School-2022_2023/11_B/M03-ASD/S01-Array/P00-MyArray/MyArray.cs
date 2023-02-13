using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

public static class MyArray
{
    public static int[] CombineArraysAndAddNum(int[] array1, int[] array2, int num)
    {
        int[] result = new int[array1.Length + array2.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + num;
        }

        int c = 0;
        for (int i = array1.Length; i < result.Length; i++)
        {
            result[i] = array2[c] + num;
            c++;
        }
        return result;
    }
    //int[] array1 = { 1, 5 };
    //int[] array2 = { 10, -5, 0 };
    //int num = 5;

    public static int[] AddUpTo10(int[] array)
    {
        int[] changedArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            changedArray[i] = 10 - array[i];
        }
        return changedArray;
    }
    public static int[] ElementsDevidedBy3AndBiggerThan15(int[] array)
    {
        int count = 0;
        
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 3 == 0 && array[i]>15)
            {
                count++;
            }
        }
        int[] elements = new int[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 3 == 0 && array[i] > 15)
            {
                elements[index] = array[i];
                index++;
            }
        }
        return elements; 
    }
    public static int SumDevidedBy3AndBiggerThan15(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 3 == 0 && array[i] >15)
            {
               sum= sum + array[i];
            }
        }
        return sum;
    }
    public static int AbsoluteSum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]<0)
            {
                sum += array[i] * (-1);
            }
            else
            {
                sum += array[i];
            }
        }
        return sum;
    }

    public static double AverageValue(int[]array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return Math.Round(sum / array.Length, 2);
    }
    public static int GetSecondLargestElement(int[] array)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>largest)
            {
                largest= array[i];
            }
        }
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > secondLargest && array[i]<largest)
            {
                secondLargest = array[i];
            }
        }
        return secondLargest;
    }
    public static int GetMaxElement(int[] array)
    {
        int max = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (max < array[i])
            {
               max = array[i];
            }
        }
        return max;
    }
    public static string Print<T>(T[] array, string separator = ", ")
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < array.Length - 1; i++)
        {
            sb.Append(array[i]);
            sb.Append(separator);
        }
        sb.AppendLine(array[array.Length - 1].ToString());
        return sb.ToString();
    }

    public static int[] RandomArray(int n, int min, int max)
    {
        Random random = new Random();
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(min, max);
        }
        return array;
    }
    public static double[] RandomArray(int n, double min, double max)
    {
        Random random = new Random();
        double[] array = new double[n];

        for (int i = 0; i < array.Length; i++)
        {
            double randomDouble = random.NextDouble();
            double randomNumber = Math.Round(random.Next((int)Math.Ceiling(min), (int)Math.Floor(max)) * randomDouble, 3);
            array[i] = randomNumber;
        }
        return array;
    }

    public static bool[] RandomArray(int n)
    {
        bool[] array = new bool[n];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            //array[i] = random.Next(-1, 2) == 0 ? false : true;
            // array[i] = random.Next(0, 20) % 2 == 0 ? false : true;
            array[i] = random.Next(-5, 5) < 0 ? false : true;
            //if (random.Next(-5, 5) < 0)
            //{
            //    array[i] = false;
            //}
            //else
            //{
            //    array[i] = true;
            //}
        }
        return array;
    }
    
}

