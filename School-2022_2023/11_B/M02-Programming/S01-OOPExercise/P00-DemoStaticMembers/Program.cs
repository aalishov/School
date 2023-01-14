using System;

public class Program
{
    static void Main()
    {
        Student s1 = new Student("Alex", 12);
        Student s2 = new Student("Jane", 15);
        
        Console.WriteLine(Student.MembersCount);
    }
}

