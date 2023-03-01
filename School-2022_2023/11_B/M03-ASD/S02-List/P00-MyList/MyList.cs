using System;
using System.Collections.Generic;
using System.Text;

public static class MyList
{
    public static List<int> CombinedList(List<int> firstList, List<int> secondList)
    {
        List <int> combinedList = new List <int>();
        combinedList.AddRange(firstList);
        for (int i = secondList.Count - 1; i >= 0; i--)
        {
            combinedList.Add(secondList[i]);
        }
        return combinedList;

    }
    public static int CountBiggerThanAbsolute(List<int> nums)
    {
        int sum = 0;
        int count = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            sum += nums[i];
        }
        double average = sum / nums.Count;
        for (int i = 0; i < nums.Count; i++)
        {
            int element = nums[i];
            if (element < 0)
            {
                element *= -1;
            }
            if (element > average)
            {
                count++;
            }
        }
        return count;
    }
    public static int SumsDivided(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            if (number > 15 && number % 3 == 0)
            {
                sum += number;
            }
        }
        return sum;
    }
    public static List<int> ReturnListGreaterThan15AndDividedBy3(List<int> numbers)
    {
        List<int> result = new List<int>();
        foreach (int number in numbers)
        {
            if (number > 15 && number % 3 == 0)
            {
                result.Add(number);
            }
        }
        return result;
    }
    public static int GetSumAbsoluteElement(List<int> nums)
    {
        int absoluteElement = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] < 0)
            {
                absoluteElement += (nums[i] * -1);
            }
            else
            {
                absoluteElement += nums[i];
            }

        }
        return absoluteElement;
    }
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
        Random random = new Random();
        for (int i = 0; i < n; i++)
        {
            bools.Add(random.Next(0, 2) == 0 ? false : true);
        }
        return bools;
    }

    public static int GetSecondLargest(List<int> nums)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] > largest)
            {
                largest = nums[i];
            }
        }
        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] > secondLargest && nums[i] < largest)
            {
                secondLargest = nums[i];
            }
        }
        return secondLargest;
    }

}

