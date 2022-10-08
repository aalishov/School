using System;

class Program
{
    static void Main()
    {
        string type = Console.ReadLine();
        int rows    =int.Parse(Console.ReadLine());
        int columns =int.Parse(Console.ReadLine());
        double income = 0.0;
        if (type == "Premiere")
        {
            income = rows * columns * 12.00;
        }
        else if (type == "Normal")
        {
            income = rows * columns * 7.50;
        }
        else if(type == "Discount")
        {
            income = rows * columns * 5.00;
        }
        Console.WriteLine($"{income:F2} leva");
    }
    
}

