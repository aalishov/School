using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());
        int[] nums = new int[length];
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write("Enter number: ");
            nums[i] = int.Parse(Console.ReadLine());
        }
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Element: {nums[i]}");
        }
    }
}

