using System;

public class Car
{
    //Полета
    private string brand;
    private string model;
    private int number;

    //Конструктори
    public Car(string brand)
    {
        this.Brand = brand;
    }
    public Car(string brand, string model)
    {
        this.Brand = brand;
        this.Model = model;
    }

    public Car(string brand, string model, int number)
    {
        this.Brand = brand;
        this.Model = model;
        this.Number = number;
    }

    //Свойства
    public string Brand
    {
        get { return this.brand; }
        set
        {
            if (value == string.Empty)
            {
                throw new InvalidOperationException("Invalid car brand!");
            }
            this.brand = value;
        }
    }
    public string Model
    {
        get { return this.model; }
        set
        {
            if (value == string.Empty)
            {
                throw new InvalidOperationException("Invalid car model!");
            }
            this.model = value;
        }
    }

    public int Number
    {
        get { return this.number; }
        set
        {
            if (!(value >= 1000 && value <= 9999))
            {
                throw new InvalidOperationException("Car number must be between 1000-9999");
            }
            this.number = value;
        }
    }
}

