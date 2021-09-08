using System;


class Program
{
    static void Main()
    {
        string shape = Console.ReadLine().ToLower();
        double result=0;

        if (shape == "square")
        {
            double a = double.Parse(Console.ReadLine());
            //Console.WriteLine(a * a);
            result = a * a;
        }
        else if (shape == "circle")
        {
            double r = double.Parse(Console.ReadLine());
            //Console.WriteLine(Math.PI * r * r);
            result = Math.PI * r * r;
        }
        else if (shape == "rectangle")
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            //Console.WriteLine(a * b);
            result = a * b;
        }
        else if (shape == "triangle")
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            //Console.WriteLine(a * h / 2);
            result = a * h / 2;
        }

        Console.WriteLine($"{result:f3}");
    }
}

