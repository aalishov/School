using System;
using System.Collections.Generic;
using System.Text;

public class Student
{
    private string firstName;
    private string lastName;
    private int age;

    public Student(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public Student(Student student)
    {
        this.FirstName = student.FirstName;
        this.LastName = student.LastName;
        this.Age = student.Age;
    }

    public string FirstName
    {
        get { return this.firstName; }
        private set
        {
            if (value.Length <= 2 || string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidNameException();
            }
            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        private set
        {
            if (value.Length <= 2 || string.IsNullOrWhiteSpace(value))
            {
                throw new InvalidNameException();
            }
            this.lastName = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        private set
        {
            if (age < 7 || age > 19)
            {
                throw new InvalidAgeException("Student invalid age!");
            }
            this.age = value;
        }
    }
}

