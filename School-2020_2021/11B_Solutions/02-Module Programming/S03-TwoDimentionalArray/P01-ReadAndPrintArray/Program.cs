using System;


class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 2] {
            { 2, 3 },
            { 3, 5 },
            { 7, 8 }
        };

        //matrix.GetLength(0) - връща броя на редовете
        //matrix.GetLength(1) - връща броя на колоните

        //ReadTwoDimensionalArray(matrix);


        PrintTwoDimensionalArray(matrix);

        Console.WriteLine(new string('*', 10));


        //Обхождане по колони
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            matrix[1, i] *= 2;
        }
        PrintTwoDimensionalArray(matrix);

        Console.WriteLine(new string('*', 10));

        //Обхождане на редове

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i,1]*= 10;
        }

        PrintTwoDimensionalArray(matrix);
    }

    private static void PrintTwoDimensionalArray(int[,] matrix)
    {
        //Отпечатване на двумерен масив
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],3} ");
            }
            Console.WriteLine();
        }
    }

    private static void ReadTwoDimensionalArray(int[,] matrix)
    {
        //Въвеждане стойност на елементите
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"Enter value for position [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
}

