using System;

class Program
{
    static void Main()
    {
        string input = "12";
        int number = int.Parse(input);
        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else { Console.WriteLine("Odd"); }
    }
}

