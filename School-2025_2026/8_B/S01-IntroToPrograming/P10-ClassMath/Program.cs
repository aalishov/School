public class Program
{
    public static void Main()
    {
        Console.WriteLine($"Pi - {Math.PI}");
        Console.WriteLine($"E - {Math.E}");
        Console.WriteLine($"Abs(-5) - {Math.Abs(-5)}");
        Console.WriteLine($"Abs(5) - {Math.Abs(5)}");
        Console.WriteLine($"Ceiling(3.1) - {Math.Ceiling(3.1)}");
        Console.WriteLine($"Ceiling(3.85) - {Math.Ceiling(3.85)}");
        Console.WriteLine($"Ceiling(6.003) - {Math.Ceiling(6.003)}");
        Console.WriteLine($"Floor(5.94) - {Math.Floor(5.94)}");
        Console.WriteLine($"Round(3.54) - {Math.Round(3.54,1)}");
        Console.WriteLine($"Round(3.66588) - {Math.Round(3.66588, 3)}");
        Console.WriteLine($"Max(3,9) - {Math.Max(3,9)}");
        Console.WriteLine($"Max(-3, -26) - {Math.Max(-3, -26)}");
        Console.WriteLine($"Min(-3, -26) - {Math.Min(-3, -26)}");
        Console.WriteLine(Math.Min(Math.Min(-5,-9),Math.Min(10,-100)));
        Console.WriteLine($"Sqrt(25) - {Math.Sqrt(25)}");
        Console.WriteLine($"Sqrt(2) - {Math.Sqrt(2)}");
        Console.WriteLine($"Sqrt(-2) - {Math.Sqrt(-2)}"); //NaN
        Console.WriteLine($"Pow(2, 10) - {Math.Pow(2, 10)}");
        Console.WriteLine($"Pow(10, 3) - {Math.Pow(10, 3)}");   
    }
}

