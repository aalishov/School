using System;
using System.Collections;
using System.Linq;

public class Program
{
    public static void Main()
    {
        byte[] nums =new byte [2_000_000];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = (byte)new Random().Next(0, 31);
        }

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }

    public int GetSumEven(int[] array) // 9n+3, 2, 4, 6
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {

            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }

        }
        return sum;
    }

}