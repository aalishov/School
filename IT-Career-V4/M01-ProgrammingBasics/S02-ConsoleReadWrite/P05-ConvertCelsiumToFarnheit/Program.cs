using System;

class Program
{
    static void Main()
    {
        double c = double.Parse(Console.ReadLine());

        //(0°C × 9/5) + 32 = 32°F

        // % - остатък от целочислено деление 
        // 12 % 8 = 4; 5 % 3 = 2; 16 % 5 = 1
        // 12 / 8 = 1; 5 / 3 = 1; 16 / 5 = 3

        double f = (c * 9.0 / 5.0) + 32;

        Console.WriteLine(f);
    }
}

