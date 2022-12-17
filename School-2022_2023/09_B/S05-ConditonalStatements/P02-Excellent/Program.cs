using System;

public class Program
{
    public static void Main()
    {
        double grade = double.Parse(Console.ReadLine());
        if (grade >= 5.5)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}
