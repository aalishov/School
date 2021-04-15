using System;

namespace P04_Employee
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee first = new Employee("Alex",1800,"C# Developer","Web");
            Employee phpDeveloper = new Employee("John", 2000, "Junior PHP", "Web");

            Console.WriteLine(first);
            Console.WriteLine(phpDeveloper);
        }
    }
}
