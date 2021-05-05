using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter elements: ");
        //Input
        double[] nums = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToArray();

        //Max, Min, Sum variable
        double maxElement = int.MinValue;
        double minElement = int.MaxValue;
        double sum = 0.0;

        for (int i = 0; i < nums.Length; i++)
        {
            double currentElement = nums[i];

            //Max element
            if (maxElement < currentElement)
            {
                maxElement = currentElement;
            }
            //Min element
            if (minElement>currentElement)
            {
                minElement = currentElement;
            }
            //Sum
            sum += currentElement;
        }

        //Print Output
        Console.WriteLine($"Max: {maxElement}");
        Console.WriteLine($"Min: {minElement}");
        Console.WriteLine($"Sum: {sum}");
        //Average
        Console.WriteLine($"Average: {sum/nums.Length:f3}");
    }
}

