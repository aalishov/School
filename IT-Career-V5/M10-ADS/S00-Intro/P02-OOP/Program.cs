using System;

public class Program
{
    static void Main()
    {
        Student student = new Student(1,"Ivan");
        Employee emloyee = new Employee("Gosho",1500);

        Console.WriteLine(student);
        Console.WriteLine(emloyee);
    }
}

