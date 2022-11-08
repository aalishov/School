using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[] nums=Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        //[0, 1, 1, 5, 2, 2, 6, 3, 3]
        //[2, 1, 1, 2, 3, 3, 2, 2, 2, 1]

        int maxCount=0;
        int maxElement=0;

        int currentElement = nums[0];
        int currentCount=1;

        for(int i = 1; i < nums.Length; i++)
        {
            if (currentElement == nums[i])
            {
                currentCount++;
            }
            else
            {
                if (currentCount>maxCount)
                {
                    maxCount = currentCount;
                    maxElement = currentElement;
                }
                currentElement = nums[i];
                currentCount=1;
            }
            if (i==nums.Length-1)
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    maxElement = currentElement;
                }
            }
        }
        Console.WriteLine($"Max element: {maxElement}");
        Console.WriteLine($"Count: {maxCount}");
    }
}
