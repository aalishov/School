using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Person> people = new List<Person>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] info = Console.ReadLine().Split(' ');
            string firstName=info[0];
            string lastName=info[1];
            int age=int.Parse(info[2]);
            decimal salary=decimal.Parse(info[3]);
            try
            {
                Person person = new Person(firstName,lastName,age,salary);
                people.Add(person);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        decimal percentage = decimal.Parse(Console.ReadLine());
        foreach (var p in people)
        {
            try
            {
                p.IncreaseSalary(percentage);
                Console.WriteLine($"{p.FirstName} {p.SecondName} {p.Age} {p.Salary}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

