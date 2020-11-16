using System;
using System.Collections.Generic;
using System.Text;


public class Car
{
    //Полета - fields
    private string model;
    private double fuel;
    private double fuelConsumption;
    private double travelledDistance;

    //Конструктор
    public Car(string model, double fuel, double fuelConsumption)
    {
        this.Model = model;
        this.Fuel = fuel;
        this.FuelConsumption = fuelConsumption;
        this.TravelledDistance = 0;
    }

    //Свойства - Properties
    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Model can't be null or emty!");
            }
            this.model = value;
        }
    }

    public double Fuel
    {
        get { return this.fuel; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Fuel can't be less then zero!");
            }
            this.fuel = value;
        }
    }

    public double FuelConsumption
    {
        get { return this.fuelConsumption; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Fuel consumption can't be less then zero or equal!");
            }
            this.fuelConsumption = value;
        }
    }

    public double TravelledDistance
    {
        get { return this.travelledDistance; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Travelled distance can't be less then zero!");
            }
            this.travelledDistance = value;
        }
    }

    //Методи
    public string Drive(double km)
    {
        double neededFuel = this.FuelConsumption * km;
        if (neededFuel <= this.Fuel)
        {
            this.TravelledDistance += km;
            this.Fuel -= neededFuel;
            return $"{this.Model} travelled {km}km! Fuel left - {this.Fuel}";
        }
        else
        {
            return $"{this.Model} - insufficient fuel for the drive!";
        }
    }

    //Метод, който връща истина/лъжа и приема един аргумент от тим double с име Km
    private bool IsPossibleToDrive(double km)
    {
        double neededFuel = this.FuelConsumption * km;
        //проверяваме дали имаме достатъчно гориво
        if (neededFuel <= this.Fuel)
        {
            //ако имаме достатъчно гориво изминаваме километрите и намаляваме горивото, което имаме
            this.TravelledDistance += km;
            this.Fuel -= neededFuel;
            return true;
        }
        else
        {
            //връщаме лъжа, защото не може да изминем километрите
            return false;
        }
    }

    public string Refuel(double liters)
    {
        if (liters <= 0)
        {
            return $"Liters must be positive number!";
        }

        bool isDrived = this.IsPossibleToDrive(2);

        if (isDrived)
        {
            this.Fuel += liters;
            return $"{this.Model} refueled with {liters} liters! Current fuel: {this.Fuel}!";
        }
        else
        {
            return $"{this.Model} doesn't have fuel to travel to gas station!";
        }
    }

    public override string ToString()
    {
        return $"Model:{this.Model}{Environment.NewLine}  =>Fuel: {this.Fuel}{Environment.NewLine}  =>Travelled distance: {this.TravelledDistance} ";
    }
}