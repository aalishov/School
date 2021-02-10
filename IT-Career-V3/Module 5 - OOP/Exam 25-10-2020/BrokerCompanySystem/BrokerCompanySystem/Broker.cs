using System;
using System.Collections.Generic;
using System.Text;

public class Broker
{    
    private string name;
    private int age;
    private string city;
    private double bonus;
    private readonly List<Building> buildings;

    public Broker(string name, int age, string city)
    {
        this.Name = name;
        this.Age = age;
        this.City = city;
        this.buildings = new List<Building>();
    }

    public virtual string Name
    {
        get { return name; }
        protected set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Broker name must not be null or empty!");
            }
            this.name = value;
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
            this.age = value;
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
            this.city = value;
        }
    }

    public double ReceiveBonus(Building building)
    {
        this.buildings.Add(building);
        double currentBonus= (double)building.RentAmount * 2.0 * building.Stars / 100.0;

        bonus += currentBonus;
        return currentBonus;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"****Broker: {Name} <{Age}>");
        sb.AppendLine($"****Location: {City}");
        sb.AppendLine($"****Bonus: {bonus}");
        foreach (var building in buildings)
        {
            sb.AppendLine($"****** {building.Name}");
        }

        return sb.ToString().TrimEnd();
    }
}

