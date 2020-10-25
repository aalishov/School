using System;
using System.Collections.Generic;
using System.Text;

public abstract class Building
{
    private string name;
    private string city;
    private int stars;
    private double rentAmount;

    protected Building(string name, string city, int stars, double rentAmount)
    {
        this.Name = name;
        this.City = city;
        this.Stars = stars;
        this.RentAmount = rentAmount;
        this.IsAvailable = true;
    }

    public virtual string Name
    {
        get { return name; }
        protected  set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Building name must not be null or empty!");
            }
            this.name = value;
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

    public int Stars
    {
        get { return stars; }
        private set
        {
            if (value < 0 || value > 5)
            {
                throw new ArgumentException("Stars cannot be less than 0 or above 5!");
            }
            this.stars = value;
        }
    }

    public double RentAmount
    {
        get { return rentAmount; }
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Rent amount cannot be less or equal to 0!");
            }
            this.rentAmount = value;
        }
    }

    public bool IsAvailable { get;  set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"****Building: {this.Name} <{this.Stars}>");
        sb.AppendLine($"****Location: {this.City}");
        sb.AppendLine($"****RentAmount: {this.RentAmount}");
        sb.AppendLine($"****Is Available: {this.IsAvailable}");

        return sb.ToString().TrimEnd();
    }
}

