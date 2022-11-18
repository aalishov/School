using System;
public class Program
{
    static void Main()
    {
        //Входни данни
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Enter xA: ");
        double xA = double.Parse(Console.ReadLine());
        Console.Write("Enter yA: ");
        double yA = double.Parse(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Enter xB: ");
        double xB = double.Parse(Console.ReadLine());
        Console.Write("Enter yB: ");
        double yB = double.Parse(Console.ReadLine());

        //Пресмята дължината на страните
        double a = Math.Abs(xA - xB);
        double b = Math.Abs(yA - yB);

        //Лице
        double s = a * b;
        //Периметър
        double p = 2 * (a + b);

        //Изход
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine();
        Console.WriteLine($"S = {s}");
        Console.WriteLine($"P = {p}");

        Console.ForegroundColor = ConsoleColor.Black;

        
    }
}

