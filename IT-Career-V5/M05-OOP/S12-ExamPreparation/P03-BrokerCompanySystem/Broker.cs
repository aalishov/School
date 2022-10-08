using System;
using System.Collections.Generic;
using System.Text;

public class Broker
{
    private readonly List<Building> buildings;
    private string name;
    private int age;
    private string city;

    public Broker(string name, int age, string city)
    {
        Name = name;
        Age = age;
        City = city;
        buildings= new List<Building>();
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Broker name must not be null or empty!");
            }
            name = value;
        }
    }
    public int Age
    {
        get { return age; }
        private set
        {
            if (value < 16 || value > 70)
            {
                throw new ArgumentException("Broker's age cannot be less than 16 or above 70!");
            }
            age = value;
        }
    }
    public string City
    {
        get { return city; }
        private set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("City must not be null or empty!");
            }
            city = value;
        }
    }
    public double Bonus { get; private set; }
    public double ReceiveBonus(Building building)
    {
        double bonus = building.RentAmount * 2.0 * building.Stars / 100.0;
        Bonus += bonus;
        buildings.Add(building);
        return bonus;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"****Broker: {Name} <{Age}>");
        sb.AppendLine($"****Location: {City}");
        sb.AppendLine($"****Bonus: {Bonus}");
        buildings.ForEach(b => sb.AppendLine($"****** {b.Name}"));
        return sb.ToString().TrimEnd();
    }
}
