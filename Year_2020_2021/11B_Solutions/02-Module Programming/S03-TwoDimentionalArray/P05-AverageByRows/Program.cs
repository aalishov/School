using System;

class Program
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        int[,] table = new int[row, col];

        for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {
                table[i, j] = int.Parse(Console.ReadLine());
            }
        }


        for (int i = 0; i < table.GetLength(0); i++)
        {
            double sum = 0;
            for (int j = 0; j < table.GetLength(1); j++)
            {
                sum += table[i, j];

                Console.Write($"{table[i, j],10} ");
            }
            Console.WriteLine($"{sum / (double)table.GetLength(1),10}");
        }
    }
}

