using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Student : IComparable<Student>
{
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public int CompareTo(Student? other)
    {
        if (this.Name.CompareTo(other.Name) > 0) return 1; else if (this.Name.CompareTo(other.Name) < 0) return -1;
        if (this.Age.CompareTo(other.Age) > 0) return 1; else if (this.Age.CompareTo(other.Age) < 0) return -1;
        return 0;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || !(obj is Student)) return false;
        Student s = (Student)obj;
        return s.Name.Equals(Name) && s.Age == Age;
    }

    public static bool operator ==(Student s1, Student s2)
    {
        if (s1.Name.CompareTo(s2.Name) == 0 && s1.Age == s2.Age)
        {
            return true;
        }
        return false;
    }
    public static bool operator !=(Student s1, Student s2)
    {
        if (s1.Name.CompareTo(s2.Name) == 0 && s1.Age == s2.Age)
        {
            return false;
        }
        return true;
    }

    public static int operator +(Student s1, Student s2)
    {
        return s1.Age + s2.Age;
    }

    public static int operator +(int sum,Student s1 )
    {
        return s1.Age + sum;
    }
}

