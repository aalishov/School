using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

public class Program
{
    public static void Main()
    {
        //Queue<int> nums = new Queue<int>(Console.ReadLine()
        //    .Split(' ')
        //    .Select(int.Parse)
        //    .ToList());

        //int num = int.Parse(Console.ReadLine());

        //if (Contains(nums, num))
        //{
        //    Console.WriteLine($"{num} Exists in the List");
        //}
        //else
        //{
        //    Console.WriteLine($"{num} Not exists in the List");
        //}

        Student s1 = new Student("John", 15, 5.7);
        Student s2 = new Student("Jane", 15, 5.60);
        Student s3 = new Student("Jane", 15, 5.90);
        Student s4 = new Student("Ivan", 15, 5.90);

        List<Student> students = new List<Student>() { s1, s2, s3 };

        Console.WriteLine(Contains(students,s4));
    }

    private static bool Contains<T>(IEnumerable<T> items, T element) where T : IComparable<T>
    {
        bool exist = false;

        foreach (var item in items)
        {
            if (item.CompareTo(element) == 0)
            {
                exist = true;
                break;
            }
        }

        return exist;
    }

    //private static bool Contains<T>(T[] nums, T num) where T : IComparable<T>
    //{
    //    bool exist = false;

    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        if (nums[i].CompareTo(num) == 0)
    //        {
    //            exist = true;
    //            break;
    //        }
    //    }

    //    return exist;
    //}




}

public class Student : IComparable<Student>
{
    public Student(string name, int age, double averageGrade)
    {
        Name = name;
        Age = age;
        AverageGrade = averageGrade;
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public double AverageGrade { get; set; }

    public int CompareTo([AllowNull] Student other)
    {
        if (this.AverageGrade > other.AverageGrade)
        {
            return 1;
        }
        else if (this.AverageGrade < other.AverageGrade)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
