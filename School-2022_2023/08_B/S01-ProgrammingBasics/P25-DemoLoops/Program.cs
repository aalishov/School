using System;

public class Program
{
    public static void Main()
    {
        int grade = int.Parse(Console.ReadLine());


        while (grade < 2 || grade > 6)
        {
            Console.WriteLine("Invalid grade!");
            grade = int.Parse(Console.ReadLine());
        }

        Console.Write($"Your grade: {grade}");
    }
}

