using System;

public class Program
{
    public static void Main()
    {
        Student s1 = new Student(1, "John");
        s1.AddGrade("Math", 5);
        s1.AddGrade("Math", 6);
        s1.AddGrade("Math", 4);
        s1.AddGrade("Math", 6);
        s1.AddGrade("IT", 6);
        s1.AddGrade("IT", 6);
        s1.AddGrade("IT", 5);
        s1.AddGrade("IT", 6);
        s1.AddGrade("English",5);
        s1.AddGrade("English", 6);
        s1.AddGrade("English", 3);
        s1.AddGrade("English", 5);
        s1.AddGrade("Bulgarian", 6);
        s1.AddGrade("Bulgarian", 6);
        s1.AddGrade("Bulgarian", 6);
        s1.AddGrade("Bulgarian", 2);
        Student s2 = new Student(2, "Alex");
        s2.AddGrade("Math", 3);
        s2.AddGrade("Math", 6);
        s2.AddGrade("Math", 6);
        s2.AddGrade("IT", 6);
        s2.AddGrade("IT", 4);
        s2.AddGrade("IT", 6);
        s2.AddGrade("English", 3);
        s2.AddGrade("English", 2);
        s2.AddGrade("English", 3);
        s2.AddGrade("English", 5);
        s2.AddGrade("Bulgarian", 4);
        s2.AddGrade("Bulgarian", 4);
        s2.AddGrade("Bulgarian", 6);
        s2.AddGrade("Bulgarian", 2);

        SchoolClass schoolClass = new SchoolClass("10-it");

        schoolClass.Add(s1);
        schoolClass.Add(s2);

        Console.WriteLine(schoolClass);
    }
}

