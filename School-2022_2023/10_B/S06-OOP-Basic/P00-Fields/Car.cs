using System;
public class Car
{
    //Полета
    private string brand;
    private string model;
    private int year;


    //Свойства
    public string Brand
    {
        get
        {
            return brand;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length <= 2)
            {
                throw new ArgumentException("Invalid car brand!");
            }
            brand = value;
        }
    }

    public string Model
    {
        get { return model; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) && value.Length < 2)
            {
                throw new ArgumentException("Invalid car model!");
            }
            model = value;
        }
    }

    public int Year
    {
        get { return year; }
        set
        {
            if (value < 1990 || value >2023)
            {
                throw new ArgumentException("Invalid car year!");
            }            
            year = value;
        }
    }


    //Методи
    public override string ToString()
    {
        return $"Car info: {Brand} {Model}, year: {Year}";
    }
}