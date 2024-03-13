using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

public static class MyArray
{
    public static int[] NumsDivide3AndBigger15(int[] nums)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]%3==0 && nums[i]>15)
            {
                count++;
            }

        }
        int[] result = new int[count];
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 3 == 0 && nums[i] > 15)
            {
                result[index]= nums[i];
                index++;
            }
        }
        return result;
    }

    public static int SumNumsDivide3AndBigger15(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 3 == 0 && array[i] > 15)
            {
                sum += array[i];
            }

        }
        return sum;
    }

    public static int SumAbs(int[] array)
    {
        int s = 0;
        int newNum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                newNum = array[i] * -1;
            }
            else
            {
                newNum = array[i];
            }
            s += newNum;
        }
        return s;
    }

    public static double GetAverage(int[] array)
    {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum / array.Length;
    }

    public static int GetSecondMax2(int[] array)
    {
        int max = int.MinValue;
        int secondMax = int.MinValue;


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                secondMax = max;
                max = array[i];
            }
        }
        return secondMax;

    }

    public static int GetSecondMax(int[] array)
    {
        int max = GetMax(array);

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == max)
            {
                array[i] = int.MinValue;
            }
        }
        return GetMax(array);

    }
    public static int GetMax(int[] array)
    {
        int max = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    public static bool[] CreateRandomBoolsArray(int n)
    {
        bool[] bools = new bool[n];

        for (int i = 0; i < bools.Length; i++)
        {
            bools[i] = new Random().Next(-5, 5) > 0 ? true : false;

            //if (new Random().Next(-5, 5) > 0)
            //{
            //    bools[i] = true;
            //}
            //else
            //{
            //    bools[i] = false;
            //}
        }

        return bools;
    }

    public static string MyJoin<T>(T[] array, string separator = ", ")
    {
        string result = string.Empty;

        for (int i = 0; i < array.Length - 1; i++)
        {
            result += $"{array[i]}{separator}";
        }
        result += array[array.Length - 1];

        return result;
    }

    public static int[] CreateRandomArray(int n, int min, int max)
    {
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max);
        }
        return array;
    }

    public static double[] CreateRandomArray(int n, double min, double max)
    {
        double[] array = new double[n];
        for (int i = 0; i < array.Length; i++)
        {

            int newMin = (int)Math.Ceiling(min);
            int newMax = (int)Math.Floor(max);

            double multiplier = new Random().NextDouble(); // 0.0 - 1.0
            int number = new Random().Next(newMin, newMax);
            array[i] = Math.Round(number * multiplier, 5);
        }

        return array;
    }

    public static decimal[] CreateRandomArray(int n, decimal min, decimal max)
    {
        decimal[] array = new decimal[n];
        for (int i = 0; i < array.Length; i++)
        {

            int newMin = (int)Math.Ceiling(min);
            int newMax = (int)Math.Floor(max);

            decimal multiplier = (decimal)new Random().NextDouble(); // 0.0 - 1.0
            int number = new Random().Next(newMin, newMax);
            array[i] = Math.Round(number * multiplier, 5);
        }

        return array;
    }
}

