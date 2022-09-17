using System;

public class Program
{
    static void Main()
    {
        Student s1 = new Student() { Age = 15, FirtName = "A",LastName="A" };
        Student s2 = new Student() { Age = 15, FirtName = "A",LastName="B" };

        int result1 = s1.CompareTo(s2);
        int result2 = s2.CompareTo(s1);
        Console.WriteLine(result1);
        Console.WriteLine(result2);
    }
}

