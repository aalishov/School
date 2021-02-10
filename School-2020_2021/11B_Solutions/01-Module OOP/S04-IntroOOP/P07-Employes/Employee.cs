using System;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    //Полета
    private string name;
    private decimal salary;
    private string position;
    private string department;
    private string email;
    private int age;

    //Конструктор
    public Employee(string name, decimal salary, string position, string department, string email, int age)
    {
        this.Name = name;
        this.Salary = salary;
        this.Position = position;
        this.Department = department;
        this.Email = email;
        this.Age = age;
    }

    //Свойства
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name is invalid!");
            }
            name = value;
        }
    }

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value < 610)
            {
                throw new ArgumentException("Salary must be greather then or equal to 610!");
            }
            salary = value;
        }
    }

    public string Position
    {
        get { return position; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Position is invalid!");
            }
            position = value;
        }
    }
    public string Department
    {
        get { return department; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Department is invalid!");
            }
            department = value;
        }
    }
    public string Email
    {
        get { return email; }
        set
        {
            //if (!(new EmailAddressAttribute().IsValid(value)))
            //{
            //    throw new ArgumentException("Email is invalid!");

            //}
            email = value;
        }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }


    //Метод
    public override string ToString()
    {
        return $"{this.Name} {this.Salary} {this.Email} {this.Age}";
    }
}

