using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        //5! = 5*4*3*2*1 = 120
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger product = 1;
        string result = $"{n}! = ";

        for (long i = n; i > 1; i--)
        {
            product *= i;
            result += $"{i} * ";
        }
        result += $"1 = {product}";
        Console.WriteLine(result);
        Console.WriteLine(product);
    }
}
