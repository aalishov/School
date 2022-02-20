using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        if (n>0)
        {
            Console.WriteLine($"Number {n} is psoitive!");
        }
        else if (n<0)
        {
            Console.WriteLine($"Number {n} is negative!");
        }
        else
        {
            Console.WriteLine("Number is zero!");
        }
    }
}

