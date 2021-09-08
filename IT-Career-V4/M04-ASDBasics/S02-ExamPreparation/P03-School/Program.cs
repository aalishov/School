using System;
using System.Collections.Generic;

namespace P03_School
{
    public class Program
    {
        private static School school = new School("School1");

        public static void Main(string[] args)
        {
            string line;

            while ("END" != (line = Console.ReadLine()))
            {
                string[] cmdArgs = line.Split(' ');

                switch (cmdArgs[0])
                {
                    case "Add":
                        AddStudent(cmdArgs[1], double.Parse(cmdArgs[2]));
                        break;
                    case "AverageResult":
                        AverageResultInRange(int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                        break;
                    case "RemoveStudents":
                        RemoveStudentsByGrade(double.Parse(cmdArgs[1]));
                        break;
                    case "SortByName":
                        SortAscendingByName();
                        break;
                    case "SortByGrade":
                        SortDescendingByGrade();
                        break;
                    case "CheckStudent":
                        CheckStudentIsInSchool(cmdArgs[1]);
                        break;
                    case "Print":
                        ProvideInformationAboutAllStudents();
                        break;
                }
            }
        }

        private static void ProvideInformationAboutAllStudents()
        {
            string[] info = school.ProvideInformationAboutAllStudents();
            foreach (string item in info)
            {
                Console.WriteLine(item);
            }
        }

        private static void CheckStudentIsInSchool(string name)
        {
            if (school.CheckStudentIsInSchool(name))
            {
                Console.WriteLine($"Student {name} is available.");
            }
            else
            {
                Console.WriteLine($"Student {name} is not available.");
            }
        }
        private static void SortDescendingByGrade()
        {
            school.SortDescendingByGrade();
            Console.WriteLine("The worst student is: " + school.Students[school.Students.Count - 1].Name);
        }
        private static void SortAscendingByName()
        {
            school.SortAscendingByName();
            Console.WriteLine("First student is: " + school.Students[0].Name);
        }
        private static void RemoveStudentsByGrade(double grade)
        {
            List<string> leftStudents = school.RemoveStudentsByGrade(grade);
            Console.WriteLine("Poor students: " + string.Join(", ", leftStudents));
        }

        private static void AverageResultInRange(int start, int end)
        {
            double averageGrade = school.AverageResultInRange(start, end);
            Console.WriteLine($"Average result: {averageGrade:f2}");
        }

        private static void AddStudent(string name, double grade)
        {
            school.AddStudent(name, grade);
            Console.WriteLine($"Added student {name}.");
        }

    }
}
