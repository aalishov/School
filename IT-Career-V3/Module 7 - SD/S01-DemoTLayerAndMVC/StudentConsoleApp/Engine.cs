using ServicesLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentConsoleApp
{
    public class Engine
    {
        private StudentService service;
        public void Run()
        {
            service = new StudentService();
            ExecuteCommand();
        }

        public void ExecuteCommand()
        {
            while (true)
            {
                Console.WriteLine(PrintMenu());
                string cmd = Console.ReadLine();
                string result = string.Empty;
                try
                {
                    switch (cmd)
                    {
                        case "0":
                            break;
                        case "1":
                            result = CreateStudent();
                            break;
                        case "2":
                            result = GetStudentById();
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                }
                
                if (result != string.Empty)
                {
                    Console.WriteLine(result);
                }
            }

        }

        private string GetStudentById()
        {
            Console.Write("-> Enter student id: ");
            int id = int.Parse(Console.ReadLine());
            return service.GetStudentInfo(id);
        }

        private string CreateStudent()
        {
            Console.Write("-> Enter id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("-> First name: ");
            string firstName = Console.ReadLine();
            Console.Write("-> First name: ");
            string lastName = Console.ReadLine();
            Console.Write("-> Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("-> School name: ");
            string schoolName = Console.ReadLine();
            return this.service.CreateStudent(id, firstName, lastName, age, schoolName);
        }

        private string PrintMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('-', 15));
            sb.AppendLine("0: Exit");
            sb.AppendLine("1: Add student");
            sb.AppendLine("2: Get student info by id");
            sb.AppendLine(new string('-', 15));
            return sb.ToString().TrimEnd();
        }
    }
}
