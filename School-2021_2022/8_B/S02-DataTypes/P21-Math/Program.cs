using System;

class Program
{
    static void Main(string[] args)
    {
        //Константи
        Console.WriteLine($"Pi = {Math.PI}");
        Console.WriteLine($"E = {Math.E}");
        //Математически функции
        //Абсолютна стойност
        Console.WriteLine($"Abs(-5) = {Math.Abs(-5)}");
        Console.WriteLine($"Abs(7.3)={Math.Abs(7.3m)}");
        //Закръгляне - нагоре
        Console.WriteLine($"Math.Ceiling(5.03) = {Math.Ceiling(5.03)}");
        Console.WriteLine($"Math.Ceiling(5.86) = {Math.Ceiling(5.86)}");
        //Закръгляне - надолу
        Console.WriteLine($"Math.Floor(5.03) = {Math.Floor(5.03)}");
        Console.WriteLine($"Math.Floor(5.86) = {Math.Floor(5.86)}");
        //По-голямо
        Console.WriteLine($"Math.Max(7,-1.5) = {Math.Max(7,-1.5)}");
        //По-малко
        Console.WriteLine($"Math.Min(7,-1.5) = {Math.Min(7, -1.5)}");
        //Коренуване
        Console.WriteLine($"Math.Sqrt(25) = {Math.Sqrt(25)}");
        Console.WriteLine($"Math.Sqrt(8) = {Math.Sqrt(8)}");
        //Степенуване
        Console.WriteLine($"Math.Pow(2,10) = {Math.Pow(2,10)}");
        Console.WriteLine($"Math.Pow(3,3) = {Math.Pow(3, 3)}");
        //Закръгляне
        Console.WriteLine($"Math.Round(2.4589,2) = {Math.Round(2.4589, 2)}");

    }
}

