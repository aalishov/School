using System;

public class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        double sum = 0;
        int failed = 0;

        for (int i = 0; i < 12; i++)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade < 4)
            {
                failed++;
            }
            if (failed == 2)
            {
                Console.WriteLine($"{name} has been excluded at {i} grade");
                break;
            }
            sum += grade;
        }

        if (failed < 2)
        {
            double average = sum / 12.0;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2} ");
        }
    }
}

