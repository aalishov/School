using System;
using System.Diagnostics.SymbolStore;

public class Program
{
    public static void Main()
    {
        //bool isTrue = true;
        //bool isFalse = false;
        //bool isTrue2 = (5 + 3 + 3 - 6) == 2 + 3;

        //bool isTrue3 = 5 > 10 && 3 > 1;
        //bool isTrue4 = !((2+2*3)==5);

        //Console.WriteLine(isTrue4);

        int x = int.Parse(Console.ReadLine());

        //a)
        //bool isTrue = x >= 1 && x <= 5;


        //b)
        bool isTrue = !(x >= 1) || !(x <= 5);
        bool isTrue2 = x < 1 || x > 5;

        Console.WriteLine(isTrue);
    }
}

