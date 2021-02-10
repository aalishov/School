using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine($"Math.Pi = {Math.PI}");
        Console.WriteLine($"Math.E (Неперово число) = {Math.E}");
        Console.WriteLine($"Math.Abs(-7) = {Math.Abs(-7)} ");
        Console.WriteLine($"Math.Abs(12) = {Math.Abs(12)} ");
        Console.WriteLine($"Math.Ceiling(3.0002) = {Math.Ceiling(3.0002)}");
        Console.WriteLine($"Math.Ceiling(5.12) = {Math.Ceiling(5.12)}");
        Console.WriteLine($"Math.Ceiling(7.999) = {Math.Ceiling(7.999)}");
        Console.WriteLine($"Math.Floor(3.0002) = {Math.Floor(3.0002)}");
        Console.WriteLine($"Math.Floor(5.54) = {Math.Floor(5.54)}");
        Console.WriteLine($"Math.Floor(7.999) = {Math.Floor(7.999)}");
        Console.WriteLine($"Math.Round(7.9945459,3) = {Math.Round(7.9945459, 3)}");
        Console.WriteLine($"Math.Round(3.66, 1) = {Math.Round(3.66, 1)}");
        Console.WriteLine($"Math.Max(5,12) = {Math.Max(5,12)}");
        Console.WriteLine($"Math.Min(5,12) = {Math.Min(5, 12)}");
        Console.WriteLine($"Math.Sqrt(25) = {Math.Sqrt(25)}");
        Console.WriteLine($"Math.Sqrt(27) = {Math.Sqrt(27)}");
        Console.WriteLine($"Math.Pow(2,10) = {Math.Pow(2,10)}");
        Console.WriteLine($"Math.Pow(5, 15) = {Math.Pow(5, 15)}");
        Console.WriteLine($"Math.Pow(3, 3) = {Math.Pow(3, 3)}");


    }
}

