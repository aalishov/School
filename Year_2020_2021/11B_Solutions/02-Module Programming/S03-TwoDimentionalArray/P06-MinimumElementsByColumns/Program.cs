using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        int[,] table = new int[row, col];

        for (int i = 0; i < table.GetLength(0); i++)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = nums[j];
            }
        }

        int[] minElements = new int[table.GetLength(1)];

        for (int i = 0; i < table.GetLength(1); i++)
        {
            int minElement = int.MaxValue;

            for (int j = 0; j < table.GetLength(0); j++)
            {
                if (table[j, i] < minElement)
                {
                    minElement = table[j, i];
                }
            }
            minElements[i] = minElement;
        }

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                Console.Write($"{table[i, j],5} ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < minElements.Length; i++)
        {
            Console.Write($"{minElements[i],5} ");
        }
    }
}

