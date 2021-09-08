using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private double price;

    public Car(int number, double price)
    {
        this.Number = number;
        this.Price = price;
    }

    public int Number { get; set; }

    public double Price
    {
        get => price; 
        set
        {
            if (value<1000)
            {
                throw new ArgumentException("Invalid car price!");
            }
            price = value;
        }
    }

    public override string ToString()
    {
        return $"Car number {this.Number} costs {this.Price:f2}";
    }
}

