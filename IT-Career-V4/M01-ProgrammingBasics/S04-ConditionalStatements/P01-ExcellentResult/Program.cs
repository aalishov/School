using System;

class Program
{
    static void Main()
    {
        double grade = double.Parse(Console.ReadLine());
        bool isExcellent = grade >= 5.5;
        if (isExcellent)
        {
            Console.WriteLine("Excellent!");
        }
        else
        {
            Console.WriteLine("Not excellent.");
        }
    }
}

