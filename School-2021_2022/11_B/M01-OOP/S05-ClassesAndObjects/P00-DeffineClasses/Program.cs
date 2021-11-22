using System;

public class Program
{
    public static void Main(string[] args)
    {
        Rectangle r1 = new Rectangle() 
        {
            Height=10,
            Width=20,
            Color="Red"
        };


        Console.WriteLine(r1.PrintArea());
    }
}

