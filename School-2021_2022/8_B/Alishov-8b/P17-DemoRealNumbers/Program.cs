using System;


class Program
{
    static void Main()
    {
        //int age = 15;
        //string name = "Alex";
        //char s = name[0];

        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double sum = num1 + num2;
        double diff = num1 - num2;
        double product = num1 * num2;
        double d = num1 / num2;
        Console.WriteLine($"{num1} + {num2} = {sum}");
        Console.WriteLine($"{num1} - {num2} = {diff}");
        Console.WriteLine($"{num1} * {num2} = {product}");
        Console.WriteLine($"{num1} / {num2} = {d}");
    }
}

