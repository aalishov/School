namespace Ex04_P01_BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        private static Stack<int> nums;
        public static void Main()
        {
            int[] input = ReadNumsArr();

            int stackLength = input[0];
            int popNum = input[1];
            int find = input[2];

            nums = new Stack<int>(ReadNumsArr());

            for (int i = 0; i < popNum; i++)
            {
                nums.Pop();
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
