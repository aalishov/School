namespace Arrays
{
    using System;
    using System.Linq;

    public class ArraysMain
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command = string.Empty;

            while (!command.Equals("stop"))
            {
                string line = Console.ReadLine().Trim();
                string[] stringParams = line.Split(ArgumentsDelimiter);
                command = stringParams[0];
                int[] args = new int[2];

                if (command.Equals("add") ||
                    command.Equals("substract") ||
                    command.Equals("multiply"))
                {
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    PerformAction(array, command, args);
                }
                else
                {
                    PerformAction(array, command, args);
                }

                PrintArray(array);
                Console.WriteLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr;
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "substract":
                    array[pos] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(array);
                    break;
                case "rshift":
                    ArrayShiftRight(array);
                    break;
                case "stop":
                    Environment.Exit(0);
                    break;
            }
        }

        private static void ArrayShiftRight(long[] array)
        {
            long shiftElement = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = shiftElement;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long shiftElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = shiftElement;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
