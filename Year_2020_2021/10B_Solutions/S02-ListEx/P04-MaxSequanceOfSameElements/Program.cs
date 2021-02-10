using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //Четем входни данни
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        //Начала позиция на най-дългата последователност
        int bestStartPosition = 1;
        int bestLength = 1;
        int currentStartPosition = 0;
        int currentLength = 1;

        for (int i = 0; i < nums.Count - 1; i++)
        {
            if (nums[i] != nums[i + 1])
            {
                if (currentLength > bestLength)
                {
                    bestLength = currentLength;
                    bestStartPosition = currentStartPosition;
                }
                currentStartPosition = i + 1;
                currentLength = 1;
            }
            else
            {
                currentLength++;
                if (i < nums.Count - 1)
                {
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStartPosition = currentStartPosition;
                    }
                }
            }

        }

        for (int i = bestStartPosition; i < (bestStartPosition + bestLength); i++)
        {
            Console.Write($"{nums[i]} ");
        }
        Console.WriteLine();
    }
}

