using System;
using System.Collections.Generic;

namespace GreedyAlgorithmsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value:");
            int targetValue = int.Parse(Console.ReadLine());

            List<int> availableNums = new List<int> { 1, 5, 10, 25 };
            List<int> usedNums = new List<int>();
            int currentValue = 0;

            while (currentValue < targetValue)
            {
                if (currentValue + availableNums[3] <= targetValue)
                {
                    currentValue += availableNums[3];
                    usedNums.Add(availableNums[3]);
                    continue;
                }
                if (currentValue + availableNums[2] <= targetValue)
                {
                    currentValue += availableNums[2];
                    usedNums.Add(availableNums[2]);
                    continue;
                }
                if (currentValue + availableNums[1] <= targetValue)
                {
                    currentValue += availableNums[1];
                    usedNums.Add(availableNums[1]);
                    continue;
                }
                if (currentValue + availableNums[0] <= targetValue)
                {
                    currentValue += availableNums[0];
                    usedNums.Add(availableNums[0]);
                    continue;
                }
            }

            Console.WriteLine("Numbers used:");
            foreach (var num in usedNums)
            {
                Console.WriteLine(num);
            }

        }
    }
}