using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Student s1 = new Student();
        s1.FirstName = "John";
        s1.LastName = "Johnson";
        s1.Age = 12;
        s1.AverageGrade = 5.3;


        Console.WriteLine(s1);
        s1.Grow();
        Console.WriteLine(s1);
    }
}

