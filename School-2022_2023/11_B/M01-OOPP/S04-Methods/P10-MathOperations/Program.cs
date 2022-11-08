using System;

public class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        char op = char.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(MathOperations(a, op, b));
    }
    static double MathOperations(double n1, char operation, double n2)
    {
        switch (operation)
        {
            case '/':
                return n1 / n2;
            case '*':
                return n1 * n2;
            case '+':
                return n1 + n2;
            case '-':
                return n1 - n2;
            default:
                return 0;
        }
    }
}
