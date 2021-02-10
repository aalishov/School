using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int rowLength = n * 2;



        int middleRows = n - 3;
        int middleRowsSpace = rowLength - 2;
        int middleColumn = n / 2;
        int specialElements = rowLength - (middleColumn * 2 + 4);

        Console.WriteLine($@"/{new string('^', middleColumn)}\{new string('_', specialElements)}/{new string('^', middleColumn)}\");

        for (int i = 0; i < middleRows; i++)
        {
            Console.WriteLine($"|{new string(' ', middleRowsSpace)}|");
        }

        Console.WriteLine($@"|{new string(' ', middleColumn + 1)}{new string('_', specialElements)}{new string(' ', middleColumn + 1)}|");


        Console.WriteLine($@"\{new string('_', middleColumn)}/{new string(' ', specialElements)}\{new string('_', middleColumn)}/");
    }
}

