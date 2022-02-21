namespace StudentSystem.ConsoleApp
{
    using StudentSystem.Data.Models;
    using StudentSystem.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Engine
    {
        private readonly StudentsService studentsService;
        private readonly CoursesService coursesService;

        public Engine(StudentsService studentsService, CoursesService coursesService)
        {
            this.studentsService = studentsService;
            this.coursesService = coursesService;
        }

        public void Run()
        {
            while (true)
            {
                PrintMenu();
                Console.WriteLine(new string('_', 10));
                Console.Write("Enter command: ");
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "1":
                        CreateStudent();
                        break;
                    case "2":
                        StudentsList();
                        break;
                    case "3":
                        RemoveStudent();
                        break;
                    case "4":
                        SearchByName();
                        break;
                    case "21":
                        CreateCourse();
                        break;
                    case "22":
                        CourseList();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;

                }
                Console.WriteLine(new string('_', 50));
            }
        }
        private void PrintMenu()
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine($"Students: 1-Create, 2-List, 3-Delete, 4-Search by name");
            Console.WriteLine($"Courses: 21-Create, 22-List, 23-Delete, 24-Search by name");
        }
        public void CourseList()
        {
            ICollection<Course> courses = coursesService.GetAllCoursesAsync().GetAwaiter().GetResult();
            if (courses.Any())
            {
                Console.WriteLine($"Courses info:");
                Console.WriteLine($"{"Id",4}{"Name",25}{"Price",6}{"Start date",14}{ "End date",14}{"Description",13}");
                foreach (var course in courses)
                {
                    string name =course.Name.Length>23?course.Name.Substring(0, 23):course.Name;
                    string description = !String.IsNullOrWhiteSpace(course.Description) ? course.Description.Substring(0, 11) : "n/a";
                    string startDate = course.StartDate != null ? ((DateTime)course.StartDate).ToString("dd/MM/yyyy") : "n/a";
                    string endDate = course.EndDate != null ? ((DateTime)course.EndDate).ToString("dd/MM/yyyy") : "n/a";
                    Console.WriteLine($"{course.Id,4}{name,25}{Math.Round(course.Price),6}{startDate,14}{ endDate,14}{description,13}");
                }
            }
            else
            {
                Console.WriteLine($"Courses not found!");
            }
        }
        private void CreateCourse()
        {
            string name = UserInput("Enter course name: ");
            string price = UserInput("Enter price: ");
            string startDate = UserInput("Enter start date: ");
            string endDate = UserInput("Enter end date: ");
            string description = UserInput("Enter course description: ");
            string output = coursesService.CreateCourseAsync(name, price, startDate, endDate, description).GetAwaiter().GetResult();
            Console.WriteLine(output);
        }
        private string UserInput(string helpMessage)
        {
            Console.Write(helpMessage);
            return Console.ReadLine();
        }
        private void SearchByName()
        {
            string name = UserInput("Enter name: ");
            List<Student> students = studentsService.SearchStudentsByNameAsync(name).GetAwaiter().GetResult().ToList();
            PrintStudents(students);
        }
        private void RemoveStudent()
        {
            Console.Write("Enter student id: ");
            string id = Console.ReadLine();
            Console.WriteLine(studentsService.RemoveStudentAsync(id).GetAwaiter().GetResult());
        }
        private void StudentsList()
        {
            List<Student> students = studentsService.GetAllStudentsAsync().GetAwaiter().GetResult().ToList();
            PrintStudents(students);
        }
        private void CreateStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter student birthdate {dd/mm/yyyy}: ");
            string birthDate = Console.ReadLine();
            Console.WriteLine(studentsService.CreateStudentAsync(name, null, birthDate).GetAwaiter().GetResult());
        }
        private static void PrintStudents(List<Student> students)
        {
            if (students.Any())
            {
                Console.WriteLine($"Students info:");
                Console.WriteLine($"{"Id",4}{"Name",10}{"Phone",12}{"BirthDate",14}");
                foreach (var student in students)
                {
                    string date = student.BirthDay != null ? ((DateTime)student.BirthDay).ToString("dd/MM/yyyy") : "n/a";
                    string phone = student.PhoneNumber != null ? student.PhoneNumber : "n/a";
                    Console.WriteLine($"{student.Id,4}{student.Name,10}{phone,12}{date,14}");
                }
            }
            else
            {
                Console.WriteLine($"Students not found!");
            }
        }
    }
}
