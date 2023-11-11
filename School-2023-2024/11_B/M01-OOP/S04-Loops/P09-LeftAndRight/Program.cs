using System;
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int leftSum = 0;
        int rightSum = 0;
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            leftSum += num;
        }

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            rightSum += num;
        }

        if (rightSum == leftSum)
        {
            Console.WriteLine($"Yes, sum = {leftSum}");
        }
        else
        {
            Console.WriteLine($"No, diff = {Math.Abs(rightSum-leftSum)}");
        }
    }
}