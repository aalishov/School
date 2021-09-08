using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class Store
{
    private readonly List<Car> cars;
    private string name;

    public Store(string name)
    {
        this.Name = name;
        cars = new List<Car>();
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (value.Length < 5)
            {
                throw new ArgumentException("Invalid store name!");
            }
            name = value;
        }
    }

    public void AddCar(Car car)
    {
        this.cars.Add(car);
    }

    public bool SellCar(Car car)
    {
        return this.cars.Remove(car);
    }

    public double CalculateTotalPrice()
    {
        //double sum = 0;
        //foreach (var car in this.cars)
        //{
        //    sum += car.Price;
        //}
        //return sum;

        return this.cars.Sum(c => c.Price);
    }

    public void RenameStore(string newName)
    {
        this.Name = newName;
    }

    public void SellAllCars()
    {
        this.cars.Clear();
    }

    public Car GetCarWithHighestPrice()
    {
        return this.cars.OrderBy(c => c.Price).LastOrDefault();
    }

    public Car GetCarWithLowestPrice()
    {
        return this.cars.OrderBy(c => c.Price).FirstOrDefault();
    }
    public override string ToString()
    {
        if (this.cars.Any())
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Store {this.Name} has {this.cars.Count} car/s:");
            foreach (var car in this.cars)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
        else
        {
            return $"Store {this.Name} has no available cars.";
        }

    }
}

