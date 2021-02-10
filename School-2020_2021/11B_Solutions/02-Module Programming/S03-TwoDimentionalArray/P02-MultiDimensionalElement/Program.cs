using System;


class Program
{
    static void Main()
    {
        int[,,] matrix = new int[4, 2, 3]
        {
            {
                { 2,2,3},
                { 3,2,2}
            },
            {
                {7,8 ,2},
                { 12,16,6}
            },
            {
                {15,12,8 },
                {15,-6,2 }
            } ,
            {
                {15,12,8 },
                {15,-6,2 }
            }
        };

        Console.WriteLine($"Rows - {matrix.GetLength(0)}");
        Console.WriteLine($"Cols - {matrix.GetLength(1)}");
        Console.WriteLine($"TwoDimensiolArrays - {matrix.GetLength(2)}");
    }
}

