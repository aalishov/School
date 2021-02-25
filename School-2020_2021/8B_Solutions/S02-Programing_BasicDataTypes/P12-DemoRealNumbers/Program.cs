using System;


class Program
{
    static void Main()
    {
        float num = 12.3f;
        double num1 = 12.31353454546545645646546545d;
        decimal num2 = 12.3545645646545645456464454m;

        var number = decimal.Parse(Console.ReadLine());
        var number2 = double.Parse(Console.ReadLine());

        Console.WriteLine(num1);
        Console.WriteLine(num2);
    }
}

