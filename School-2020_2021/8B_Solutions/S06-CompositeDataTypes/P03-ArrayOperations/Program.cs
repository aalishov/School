using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        double[] numbers = Console.ReadLine()
             .Split(' ')
             .Select(double.Parse)
             .ToArray();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= 3; //numbers[i]=numbers[i]*3;
        }

        Console.WriteLine(string.Join(" | ",numbers));
    }
}

