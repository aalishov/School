using System;
public class Program
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        if (n>0)
        {
            Console.WriteLine("Number is positive!");
        }
        else if (n<0)
        {
            Console.WriteLine("Number is negative!");
        }
        else
        {
            Console.WriteLine("Number is zero!");
        }
    }
}

