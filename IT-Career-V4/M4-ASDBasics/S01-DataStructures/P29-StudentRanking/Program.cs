using System;

public class Program
{
    public static void Main()
    {
        Student s1 = new Student(1, "John");
        s1.AddGrade("Math", 6);
        s1.AddGrade("Math", 6);
        s1.AddGrade("Math", 6);
        s1.AddGrade("Math", 6);
        s1.AddGrade("IT", 6);
        s1.AddGrade("IT", 6);
        s1.AddGrade("IT", 6);
        s1.AddGrade("IT", 6);
        s1.AddGrade("English",6);
        s1.AddGrade("English", 6);
        s1.AddGrade("English", 6);
        s1.AddGrade("English", 6);
        s1.AddGrade("Bulgarian", 6);
        s1.AddGrade("Bulgarian", 6);
        s1.AddGrade("Bulgarian", 6);
        s1.AddGrade("Bulgarian", 6);
        Console.WriteLine(s1);
    }
}

