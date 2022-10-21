using System;


public class Program
{
    static void Main()
    {
        string name = Console.ReadLine();
        int klas = 1; int fail = 0;
        double allGrades = 0;
        while (klas <= 12)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 4.00)
            {
                klas++;
                allGrades += grade;
            }
            else { fail++; }
            if (fail > 1)
            {
                Console.WriteLine($"{name} has been excluded at {klas} grade");
                break;
            }
        }
        if (fail < 1)
        {
            Console.WriteLine($"{name} graduated. Average grade: {(allGrades / 12.00):f2}");
        }
    }
}

