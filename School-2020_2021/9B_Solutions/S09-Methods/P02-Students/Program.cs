using System;

namespace P02_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintStudent(ReadName(), ReadAge(), ReadGrade());
            PrintStudent(ReadName(), ReadAge(), ReadGrade());
        }

        public static void PrintStudent(string name, int age, double grade)
        {
            Console.WriteLine("Student: {0}; Age: {1}, Grade: {2}", name, age, grade);
        }

        public static string ReadName()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            return name;
        }

        public static int ReadAge()
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            return age;
        }

        public static double ReadGrade()
        {
            Console.Write("Enter grade: ");
            double grade = double.Parse(Console.ReadLine());
            return grade;
        }
    }
}
