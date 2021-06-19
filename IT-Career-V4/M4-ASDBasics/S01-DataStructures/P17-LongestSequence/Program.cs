using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        int index = 0;
        int counter = 0;

        int tempIndex = 0;
        int tempCounter = 1;
        //4 4 2 5 5 5
        for (int i = 0; i < nums.Count - 1; i++)
        {
            if (nums[i] == nums[i + 1]) { tempCounter++; }
            else
            {
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    index = tempIndex;
                }

                tempCounter = 1;
                tempIndex = i + 1;
            }
        }
        if (tempCounter > counter)
        {
            counter = tempCounter;
            index = tempIndex;
        }

        for (int i = index; i < index + counter; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}
