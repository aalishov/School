﻿using System;

public class Program
{
    public static void Main()
    {
        double num = double.Parse(Console.ReadLine());
        if (num<=10)
        {
            Console.WriteLine($"slow");
        }
        else if (num<=50)
        {
            Console.WriteLine($"average");
        }
        else if (num<=150)
        {
            Console.WriteLine($"fast");
        }
        else if (num<=1000)
        {
            Console.WriteLine($"ultra fast");
        }
        else
        {
            Console.WriteLine($"extremely fast");
        }
    }
}

