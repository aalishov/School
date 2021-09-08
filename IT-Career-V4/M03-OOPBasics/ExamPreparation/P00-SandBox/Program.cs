using System;

namespace P00_SandBox
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine(string.Join(", ",arr));
        }
    }
    public class Student
    {
        public Student(string name, int age, decimal grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public decimal Grade { get; set; }
    }
}
