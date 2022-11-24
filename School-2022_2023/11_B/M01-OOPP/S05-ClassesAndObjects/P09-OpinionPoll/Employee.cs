using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    private string name;
    private int age;

    public Employee()
    {
        Name = "No name";
        Age = 1;
    }
    public Employee(int age) : this()
    {
        Age = age;
    }
    public Employee(string name,int age):this(age)
    {
        Name = name;
    }
    public string Name
    {
        get { return name; }
        set
        {
            name = value;
        }
    }
    public int Age
    {
        get { return age; }
        set
        {
            age = value;
        }
    }
}

