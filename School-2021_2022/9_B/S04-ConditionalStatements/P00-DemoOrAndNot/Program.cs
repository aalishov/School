using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(5 > 3 && 4 > 8); //FALSE
        Console.WriteLine(5 > 3 || 4 > 8); //TRUE
        Console.WriteLine(!(5 != 2 && 8 > 2));//FALSE
    }
}

