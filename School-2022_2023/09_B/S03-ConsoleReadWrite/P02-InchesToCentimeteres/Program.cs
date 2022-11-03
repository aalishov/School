using System;

public class Program
{
    public static void Main()
    {
        const double Inch = 2.54;

        string input = Console.ReadLine();
        double inches = double.Parse(input);
        double centimeteres = Inch * inches;
        Console.WriteLine(centimeteres);
    }
}
