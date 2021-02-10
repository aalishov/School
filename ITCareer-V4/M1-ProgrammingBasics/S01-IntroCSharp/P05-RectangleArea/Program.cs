using System;
class Program
{
    static void Main()
    {
        //Console.Write("Enter a:");
        double a = double.Parse(Console.ReadLine());
        //Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        double s = a * b;

        //Console.WriteLine($"S = {s}");
        Console.WriteLine(s);
    }
}

