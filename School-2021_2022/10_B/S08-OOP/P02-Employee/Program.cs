using System;
public class Program
{
    public static void Main()
    {
        Employee e1 = new Employee("Alex", "Petrov", 1500);
        e1.IncreaseSalary();
        Console.WriteLine(e1);
        e1.ChangeFirstName("John");
        e1.IncreaseSalary();
        Console.WriteLine(e1);
    }
}

