namespace P01_EfOneToOne
{
    using Microsoft.EntityFrameworkCore.Internal;
    using Data;
    using Data.Models;
    using System;
    using System.Linq;
    public class Program
    {
        private static AppDbContext context = new AppDbContext();
        public static void Main()
        {
            Run();
        }

        public static void Run()
        {
            while (true)
            {
                Menu();
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        PrintPersonInfo();
                        break;
                    case "2":
                        CreatePerson();
                        break;
                    case "3":
                        ChangePersonSalaryById();
                        break;
                    case "4":
                        DeletePersonById(); break;
                    case "5":
                        PrintTopPayedPerson(); break;
                    case "6":
                        ChangePersonAgeById();
                        break;
                       
                    default:
                        Console.WriteLine("> Invalid command!");
                        break;
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine("Commands: 1: Print, 2: Create, 3:Change salary, 4: Delete, 5: Top payed, 0: Exit");
            Console.Write("> Select command: ");
        }

        public static void PrintTopPayedPerson()
        {
            Person person = context.People
                .OrderBy(x => x.Salary)
                .LastOrDefault();
            if (person != null)
            {
                Console.WriteLine($"Top payed person: ");
                Console.WriteLine( $"\tName: {person.Name}");
                Console.WriteLine($"\tPassport: {person.Passport.Number}");
                Console.WriteLine($"\tSalary: {person.Salary:f2}");
            }
            else
            {
                Console.WriteLine("> Empty database!");
            }
        }

        public static void DeletePersonById()
        {
            Console.Write("> Enter user id: ");
            int id = int.Parse(Console.ReadLine());
            Person person = context.People.Find(id);
            if (person != null)
            {
                context.People.Remove(person);
                context.SaveChanges();
                Console.WriteLine("> Person removed!");
            }
            else
            {
                Console.WriteLine("> Person not found!");
            }
        }

        public static void ChangePersonAgeById()
        {
            Console.Write("> Enter user id: ");
            int id = int.Parse(Console.ReadLine());
            Person person = context.People.Find(id);
            if (person != null)
            {
                Console.Write("> Enter new age: ");
                int age = int.Parse(Console.ReadLine());
                person.Age = age;
                context.People.Update(person);
                context.SaveChanges();
                Console.WriteLine("> Person age updated!");
            }
            else
            {
                Console.WriteLine("> Person not found!");
            }
        }

        public static void ChangePersonSalaryById()
        {
            Console.Write("> Enter user id: ");
            int id = int.Parse(Console.ReadLine());
            Person person = context.People.Find(id);
            if (person != null)
            {
                Console.Write("> Enter new salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());
                person.Salary = salary;
                context.People.Update(person);
                context.SaveChanges();
                Console.WriteLine("> Person salary updated!");
            }
            else
            {
                Console.WriteLine("> Person not found!");
            }
        }

        public static void CreatePerson()
        {
            Console.Write("> Enter name: ");
            string name = Console.ReadLine();
            Console.Write("> Enter salary: ");
            decimal salary = decimal.Parse(Console.ReadLine());
            Console.Write("> Enter passport number: ");
            string number = Console.ReadLine();
            Console.Write("> Enter age: ");
            int age = int.Parse(Console.ReadLine());
            if (number.Length != 8)
            {
                Console.WriteLine("> Invalid passport number!");
                return;
            }
            Passport passport = new Passport() { Number = number };
            Person person = new Person()
            {
                Name = name,
                Salary = salary,
                Passport = passport,
                Age=age
            };
            context.People.Add(person);
            context.SaveChanges();
            Console.WriteLine("> Person is added!");
        }

        public static void PrintPersonInfo()
        {
            if (context.People.Any())
            {
                string firstRow = $"| {"Id",-4} | {"Name",-10} | {"Salary",-8} | {"Passport",-10} | {"Age",-4}|";
                Console.WriteLine(firstRow);
                string line = $"|{new string('-', firstRow.Length - 2)}|";
                Console.WriteLine(line);
                foreach (var p in context.People.ToList())
                {
                    Console.WriteLine($"| {p.Id,-4} | {p.Name,-10} | {p.Salary.ToString("f2"),-8} | {p.Passport.Number,-10} | {p.Age,-4}|");
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("> Empty database!");
            }
        }
    }
}
