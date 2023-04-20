using System;
using System.Threading;

public class Program
{
    private static int count;
    public static void Main(string[] args)
    {
        int num = 5;

        int[] nums = new int[] { 0, 0, 0 };

        ChangeNum(ref num);
        ChangeNums(nums);

        Console.WriteLine(num);
        Console.WriteLine(string.Join(", ", nums));
    }

    public static void ChangeNum(ref int num)
    {
        num = 15;
    }
    public static void ChangeNums(int[] num)
    {
        num[0] = 8;
    }
}

