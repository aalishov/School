using System;

public class Program
{
    public static void Main()
    {
        int grade = 0;
        do
        {
            Console.Write("Enter number: ");
            grade = int.Parse(Console.ReadLine());
        } while (grade > 6 || grade < 2);


        Console.Write($"Your grade: {grade}");
    }
}

