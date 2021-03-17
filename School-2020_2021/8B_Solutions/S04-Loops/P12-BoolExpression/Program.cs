using System;

class Program
{   //Задача 2 - стр. 102
    static void Main()
    {
        //A)
        int a = 15;
        int b = 15;
        int c = -16;

        bool isPositive = a > 0 && b > 0 && c > 0;

        Console.WriteLine($"Is positive: {isPositive}");

        //Б)
        int x = 0;
        bool isInRange3_10 = x >= 3 && x <= 15;
        Console.WriteLine($"Is in range [3; 10] : {isInRange3_10}");

        //В)
        int p = 16;
        bool isEvenAndPositive = p > 0 && p % 2 == 0;
        Console.WriteLine($"Is even and positive : {isEvenAndPositive}");
    }
}

