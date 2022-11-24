using System;

public class Car
{
    //Полета
    private string make;
    private string model;
    private int year;
    private double fuelQuantity;
    private double fuelComnsumption;
    private Engine engine;
    private Tire[] tires;

    public Car() { }

    public Car(string make, string model) : this()
    {
        Make = make;
        Model = model;
    }

    public Car(string make, string model, int year) : this(make, model)
    {
        Year = year;
    }

    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
    {
        FuelQuantity = fuelQuantity;
        FuelConsumption = fuelConsumption;
    }

    public Car(string make,string model,int year, double fuelQuantity, double fuelConsumption,Engine engine, Tire[] tires):this(make,model,year,fuelQuantity,fuelConsumption)
    {
        Engine = engine;
        Tires = tires;
    }

    //Свойства
    public string Make
    {
        get { return make; }
        set { make = value; }
    }
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    public double FuelQuantity
    {
        get { return fuelQuantity; }
        set { fuelQuantity = value; }
    }
    public double FuelConsumption
    {
        get { return fuelComnsumption; }
        set { fuelComnsumption = value; }
    }
    public Engine Engine
    {
        get { return engine; }
        set { Engine = value; }
    }
    public Tire[] Tires
    {
        get { return tires; }
        set { tires= value; }
    }

    //Методи
    public void Drive(double distance)
    {
        double tripFuel = FuelConsumption / 100.0 * distance;
        if (tripFuel <= FuelQuantity)
        {
            FuelQuantity -= tripFuel;
            Console.WriteLine($"Distance: {distance}, current fuel: {FuelQuantity}");
        }
        else
        {
            Console.WriteLine($"Not enough fuel to perform this trip!");
        }
    }
    public string WhoAmI()
    {
        return $"Make: {Make}{Environment.NewLine}Model: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}L";
    }
}

