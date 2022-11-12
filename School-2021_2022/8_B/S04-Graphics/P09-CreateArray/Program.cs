using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter elements count: ");
        int count = int.Parse(Console.ReadLine());
        int[] nums = new int[count];

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"Enter element value [{i}]: ");
            nums[i]= int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"Element [{i}] = {nums[i]}");
        }
    }
}

