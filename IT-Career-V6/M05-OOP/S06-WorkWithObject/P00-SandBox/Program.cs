using System.Collections;

namespace P00_SandBox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School school = new School() { Name = "Vasil Levski" };
            Student s1 = new Student() { Name = "John", Age = 12 };
            Student s2 = new Student() { Name = "Jane", Age = 12 };
            Student s3 = new Student() { Name = "Alex", Age = 12 };

            school.Add(s1);
            school.Add(s2);
            school.Add(s3);

            foreach (var s in school)
            {
                Console.WriteLine(s);
            }

            PrintNames("John", "Jane", "Alex", "Ivan");

            SumNums(5, 3, 6, 8, 12, 56, 0, -8);
        }
        public static int SumNums( params int[] nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            return sum;
        }


        public static void PrintNames(params string[] names)
        {
            foreach (var name in names)
                Console.WriteLine(name);
        }

    }

    public class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public double AverageGrade { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name}: {Name}, age: {Age}";
        }
    }

    public class School : IEnumerable<Student>
    {
        private List<Student> students = new List<Student>();

        public string Name { get; set; }

        public void Add(Student student)
        {
            students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < students.Count; i++)
            {
                yield return students[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}