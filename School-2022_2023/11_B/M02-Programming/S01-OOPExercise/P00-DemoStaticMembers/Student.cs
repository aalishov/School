using System;
using System.Collections.Generic;
using System.Text;


public class Student
{
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
        MembersCount++;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public static int MembersCount { get; private set; }
}

