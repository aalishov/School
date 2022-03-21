using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        int[,] vs = new int[2, 2];
        for (int rows = 0; rows < vs.GetLength(0); rows++)
        {
            for (int cols = 0; cols < vs.GetLength(1); cols++)
            {
                vs[rows, cols] = int.Parse(Console.ReadLine());
            }
        }
        for (int rows = 0; rows < vs.GetLength(0); rows++)
        {
            for (int cols = 0; cols < vs.GetLength(1); cols++)
            {
                Console.Write($"{vs[rows, cols],5}");
            }
            Console.WriteLine();
        }
    }
}

