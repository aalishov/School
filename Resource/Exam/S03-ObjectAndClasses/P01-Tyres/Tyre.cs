using System;

public class Tyre
{
    public Tyre(int year, double pressure)
    {
        this.Year = year;
        this.Pressure = pressure;
    }

    public int Year { get; set; }
    public double Pressure { get; set; }
}

public class Person
{
    public Person(string name, string age)
    {
        this.name = name;
    }
    private string name;
    public string Name
    {
        get {  return name; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Name cannot be less than3 symbols");
            }
            name = value;
        }
    }
}