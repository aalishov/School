﻿using System;


internal class Program
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        GetSmallestNum(a,b,c);
    }
    static void GetSmallestNum(int a, int b, int c)
    {
        if (a < b && a < c)
        {
            Console.WriteLine(a);
        }
        else if (b < a && b < c)
        {
            Console.WriteLine(b);
        }
        else 
        {
            Console.WriteLine(c);
        }
        
    }
}

