using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    { 
        //3, 5, 7, 0
        int sum = 0;
        while (true)
        {
            Console.Write("Enter number: ");
            var n = int.Parse(Console.ReadLine());
            if (n == 0)
            {
                break;
            }
            sum += n;
        }
        Console.WriteLine(sum);
    }
}

