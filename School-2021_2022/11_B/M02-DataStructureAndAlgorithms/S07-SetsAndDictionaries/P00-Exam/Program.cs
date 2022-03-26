using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        int[,] vs = new int[4, 4];
        vs[0, 0] = 15;
        for (int i = 0; i < vs.GetLength(0); i++)
        {
            for (int j = 0; j < vs.GetLength(1); j++)
            {
                Console.Write(vs[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
}

