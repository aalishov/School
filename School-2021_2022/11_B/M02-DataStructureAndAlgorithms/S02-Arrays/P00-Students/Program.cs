using System;

namespace P00_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            students[0] = new Student("Student 1", "11 b");
            students[1] = new Student("Student 2", "11 b");
            students[2] = new Student("Student 3", "11 b");

            Random random = new Random();
            for (int i = 0; i < 5; i++)
            {
                students[0].AddGrade(random.Next(2,6));
                students[1].AddGrade(random.Next(2, 6));
                students[2].AddGrade(random.Next(2, 6));
            }


            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine(student.PrintGrades());
            }
        }
    }
}
