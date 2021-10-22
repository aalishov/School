using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        //5!=5*4*3*2*1=120;
        BigInteger product = 1;

        for (int i = 1; i <=n ; i++)
        {
            product= BigInteger.Multiply(product, i);
        }

        Console.WriteLine($"{n}!={product}");
    }
}

