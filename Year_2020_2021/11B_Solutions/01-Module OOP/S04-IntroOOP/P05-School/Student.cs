using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


public class Student
{
    private List<double> grades;


    //Конструктор
    public Student(string firstName, string lastName, int age, string address,bool isMale) 
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Address = address;
        this.IsMale = isMale;
        this.grades = new List<double>();
    }

    //Свойства
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Age { get; set; }

    public string Address { get; set; }

    public bool IsMale { get; set; }

    public string Class { get; set; }

    public ReadOnlyCollection<double> Grades { get => grades.AsReadOnly(); }

    //Методи
    public string Add(double grade)
    {
        if (grade >= 2 && grade <= 6)
        {
            this.grades.Add(grade);
            return $"Grade added!";
        }
        else
        {
            return $"Invalid grade!";
        }
    }

    public string Info()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"    First name: {this.FirstName}");
        sb.AppendLine($"    Last name: {this.LastName}");
        sb.AppendLine($"    Age: {this.Age}");
        sb.AppendLine($"    Address: {this.Address}");
        sb.AppendLine($"    Average grade: {this.Grades.Average()}");
        if (IsMale)
        {
            sb.AppendLine($"    Gender: male");
        }
        else
        {
            sb.AppendLine($"    Gender: female");
        }

        return sb.ToString().TrimEnd();
    }
}

