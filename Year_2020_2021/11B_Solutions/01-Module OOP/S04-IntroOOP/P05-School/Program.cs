using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;

public class Program
{
    public static void Main()
    {

        Student s1 = new Student("Ivan", "Ivanov", 15, "Velingrad",true);
        Student s2 = new Student("Nikola", "Ivanov", 23, "Plovdiv",true);
        Student s3 = new Student("Petq", "Ivanova", 16, "Vidin", false);

        Console.WriteLine(s1.Add(5));
        Console.WriteLine(s1.Add(55));
        Console.WriteLine(s1.Add(5.40));
        Console.WriteLine(s2.Add(5.3));
        Console.WriteLine(s2.Add(4.8));
        Console.WriteLine(s3.Add(4.8));



        School school = new School("Vasil Levski");
        school.Students.Add(s1);
        school.Students.Add(s2);

        School school1 = new School("Kiril i Metodii");
        school1.Students.Add(s3);

        Console.WriteLine(school.Info());
        Console.WriteLine(school1.Info());
    }
}


