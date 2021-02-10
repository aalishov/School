namespace Ex04_P03_MaxMinStackElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public  class Program
    {
        private static Stack<int> nums = new Stack<int>();

        static void Main()
        {
            int numCmd = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCmd; i++)
            {
                int[] cmdInput = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                int cmd = cmdInput[0];

                Action(cmdInput, cmd);
            }

            Console.WriteLine(string.Join(", ",nums));
        }

        private static void Action(int[] cmdInput, int cmd)
        {
            switch (cmd)
            {
                case 1:
                    PushElement(cmdInput);
                    break;
                case 2:
                    nums.Pop();
                    break;
                case 3:
                    Console.WriteLine(nums.Max());
                    break;
                case 4:
                    Console.WriteLine(nums.Min());
                    break;
                default:
                    break;
            }
        }

        private static void PushElement(int[] cmdInput)
        {
            int num = cmdInput[1];
            nums.Push(num);
        }
    }
}
