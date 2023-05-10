using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter array length: ");
        int length = int.Parse(Console.ReadLine());

        //Declare array
        int[] nums = new int[length];

        //Read elements value
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write($"Enter element value [{i}]: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        //Print array numbers
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine($"Element[{i}] = {nums[i]}");
        }

        // Sum
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        Console.WriteLine($"Sum = {sum}");

        //Odd numbers count
        int oddCounter = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 == 1)
            {
                oddCounter++;
            }
        }

        Console.WriteLine($"Odd nums count = {oddCounter}");
    }
}