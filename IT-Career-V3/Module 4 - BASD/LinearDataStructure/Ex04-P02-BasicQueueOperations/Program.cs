namespace Ex04_P02_BasicQueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static Queue<int> nums;
        public static void Main()
        {
            int[] input = ReadNumsArr();

            int qLength = input[0];
            int popNum = input[1];
            int find = input[2];

            nums = new Queue<int>(ReadNumsArr());

            for (int i = 0; i < popNum; i++)
            {
                nums.Dequeue();
            }

            PrintResult(find);
        }

        private static void PrintResult(int find)
        {
            if (nums.Contains(find))
            {
                Console.WriteLine("true");
            }
            else
            {
                int minElement = nums.Min();
                Console.WriteLine(minElement);
            }
        }

        private static int[] ReadNumsArr()
        {
            return Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}

