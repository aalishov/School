using System;
using System.Collections.Generic;
using System.Text;


public class Student
{
    private string name;

    public Student(string name)
    {
        Name = name;
    }

    public string Name
    {
        get { return $"-" + name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid name!");
            }
            if (value.Length <= 1)
            {
                throw new ArgumentException("Invalid name length!");
            }
            name = value;
        }
    }


}

