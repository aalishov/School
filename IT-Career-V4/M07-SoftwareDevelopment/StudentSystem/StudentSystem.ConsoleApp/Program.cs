using StudentSystem.Services;
using System;
using System.Collections.Generic;

namespace StudentSystem.ConsoleApp
{
    internal class Program
    {
        public static StudentsService studentsService = new StudentsService();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter command: ");
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "1":
                        CreateStudent();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;

                }
            }
        }

        public static async void CreateStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student birthdate {dd/mm/yyyy}: ");
            string birthDate = Console.ReadLine();
            try
            {
                await studentsService.CreateStudentAsync(name, null, birthDate);
                Console.WriteLine("Student added!");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
