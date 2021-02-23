using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarStore
{
    public class Store
    {
        private string name;
        private List<Car> cars;

        public Store(string name)
        {
            this.Name = name;
            this.cars = new List<Car>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                this.name = value;
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
            return this.cars.Sum(x => x.Price);
        }

        public Car GetCarWithHighestPrice()
        {
            return this.cars
                .OrderByDescending(x => x.Price)
                .FirstOrDefault();
        }

        public Car GetCarWithLowestPrice()
        {
            return this.cars
                .OrderBy(x => x.Price)
                .FirstOrDefault();
        }

        public void RenameStore(string newName)
        {
            this.Name = newName;
        }

        public void SellAllCars()
        {
            this.cars.Clear();
        }

        public override string ToString()
        {
            if (this.cars.Count()>0)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Store {this.Name} has {this.cars.Count()} car/s:");
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
}
