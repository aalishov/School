using System;
using System.Collections.Generic;
using System.Text;


public class Person
{
    private string firstName;
    private string secondName;
    private int age;
    private decimal salary;

    public Person(string firstName, string secondName, int age, decimal salary)
    {
        this.FirstName = firstName;
        this.SecondName = secondName;
        this.Age = age;
        this.Salary = salary;
    }

    public string FirstName
    {
        get { return firstName; }
        private set 
        {
            if (value.Length<3)
            {
                throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
            }
            firstName = value; 
        }
    }
   
    public string SecondName
    {
        get { return secondName; }
        private set 
        {
            if (value.Length<3)
            {
                throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
            }
            secondName = value;
        }
    }
    

    public int Age
    {
        get { return age; }
        private set 
        {
            if (value<=0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
            age = value;
        }
    }
    

    public decimal Salary
    {
        get { return salary; }
        private set 
        {
            if (value<460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva!");
            }
            salary = value; 
        }
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.Age>30)
        {
            this.Salary += this.Salary * percentage / 100;
        }
        else
        {
            this.Salary += this.Salary * percentage / 200;
        }
    }



}

