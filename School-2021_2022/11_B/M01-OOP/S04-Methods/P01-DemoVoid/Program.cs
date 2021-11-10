using System;

public class Program
{
    public static void Main()
    {
        //PrintHelloWorld();
        //PrintSquareArea();
        //PrintStars();
        //PrintCharLine('|');
        //PrintCharLine('@');
        //PrintCharLine();

        //Console.WriteLine($"My name is {ReadName()}");
        Console.WriteLine(PrintPriceInfo(10, 100));
    }

    public static string PrintPriceInfo(double percent, double money)
    {
        return $"Price: {CalculatePriceAfterDiscount(percent,money):c2}{Environment.NewLine}You save: {CalculateDiscount(percent,money):c2}";
    }

    public static double CalculatePriceAfterDiscount(double percent, double money)
    {
        return money - CalculateDiscount(percent,money);
    }

    public static double CalculateDiscount(double percent, double money)
    {
        return money * percent / 100.0;
    }

    public static string ReadName()
    {
        Console.Write("Enter name: ");
        string name= Console.ReadLine();
        return name;
    }

    public static void ModifyInt(ref int num)
    {
        num *= 10;
        Console.WriteLine(num);
    }
    public static void ModifyString(string result)
    {
        result += "12";
        Console.WriteLine(result);
    }

    public static void PrintCharLine(char symbol = '+')
    {
        Console.WriteLine(new string(symbol, 25));
    }

    public static void PrintSquareArea()
    {
        PrintStars();
        //Input
        Console.Write($"Enter area: ");
        double a = double.Parse(Console.ReadLine());
        //Calculations
        double s = a * a;
        double p = 4 * a;
        //Output
        Console.WriteLine($"S = {s:f3}");
        Console.WriteLine($"P = {p:f3}");
    }

    public static void PrintStars()
    {
        Console.WriteLine(new string('*', 25));
    }
    public static void PrintDash()
    {
        Console.WriteLine(new string('-', 25));
    }
    public static void PrintHelloWorld()
    {
        Console.WriteLine(new string('*', 25));
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}!");
        Console.WriteLine(new string('-', 25));
    }
}

