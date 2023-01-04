using System;


public class Program
{
    public static void Main()
    {
        Console.WriteLine(Operation.Add(2,7));
        Console.WriteLine(Operation.Add(2.5,7.5,6.1));
        Console.WriteLine(Operation.Add(5m,3.2m,9.7m));
    }
}

