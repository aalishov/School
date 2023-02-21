using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class MyList
{
    public static int GetMinElement(List<int> nums)
    {
        int minNum = int.MaxValue;
        for (int i = 0; i < nums.Count; i++)
        {
            if (minNum > nums[i])
            {
                minNum = nums[i];
            }
        }
        return minNum;
    }
    public static int GetMaxElement(List<int> nums)
    {
        int maxNum = int.MinValue;
        for (int i = 0; i < nums.Count; i++)
        {
            if (maxNum < nums[i])
            {
                maxNum = nums[i];
            }
        }
        return maxNum;
    }
    public static string PrintList<T>(List<T> list, string separator = ", ")
    {
        if (list.Count == 0) { return string.Empty; }
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < list.Count - 1; i++)
        {
            sb.Append(list[i]);
            sb.Append(separator);
        }
        sb.Append(list[list.Count - 1]);
        return sb.ToString();
    }
    public static List<int> RandomList(int n, int min, int max)
    {
        List<int> randomNums = new List<int>();
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            int randomNum = random.Next(min, max);
            randomNums.Add(randomNum);
        }
        return randomNums;
    }
    public static List<double> RandomList(int n, double min, double max)
    {
        List<double> randomNums = new List<double>();
        Random random = new Random();
        int minNum = (int)Math.Ceiling(min);
        int maxNum = (int)Math.Floor(max);
        for (int i = 0; i < n; i++)
        {
            int randomNum = random.Next(minNum, maxNum);
            double randomD = random.NextDouble();
            randomNums.Add(Math.Round(randomNum * randomD, 2));
        }
        return randomNums;
    }
    public static List<bool> RandomBoolList(int n)
    {
        List<bool> bools = new List<bool>();
        Random random=new Random();
        for (int i = 0; i < n; i++)
        {
            bools.Add(random.Next(0, 2) == 0 ? false : true);
        }
        return bools;
    }
    
}

