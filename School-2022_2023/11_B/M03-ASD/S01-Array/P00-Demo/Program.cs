using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        //int[] nums =Console.ReadLine()
        //    .Split(',')
        //    .Select(int.Parse)
        //    .ToArray();
        int[] nums1 = new int[] { 9, 7, 6, 1, 2, 3, 4, 5 };
        int[] nums3 = nums1;
        int[] nums2 = new int[30];

        //Array.Copy(nums1, 1, nums2, 10, 4);

        //Array.Sort(nums3);
        //Array.Reverse(nums1);

        int[] evens = nums1.Where(x => x % 2 == 0).ToArray();

        Console.WriteLine(string.Join(", ", nums3));
    }

    public double Sum(double[] nums)
    {
        double sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        return sum;
    }

    public int[] EvenNums(int[] nums)
    {
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i]%2==0)
            {
                count++;
            }
        }

        int[] result = new int[count];

        int insertIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 0)
            {
                result[insertIndex]= nums[i];
                insertIndex++;
            }
        }

        return result;
    }


}
class Student
{

}

