using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        Student s1 = new Student() { Age = 12, AverageGrade = 5 };
        Student s2 = new Student() { Age = 12, AverageGrade = 5 };
        Console.WriteLine(s1.CompareTo(s2));


    }
}

