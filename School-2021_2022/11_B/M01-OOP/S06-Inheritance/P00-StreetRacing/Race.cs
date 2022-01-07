using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P00_StreetRacing
{
    public class Race
    {
        private readonly List<Car> cars;

        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
            this.cars = new List<Car>();
        }

        public string Name { get; set; }
        public string Type { get; set; }
        public int Laps { get; set; }
        public int Capacity { get; set; }
        public int MaxHorsePower { get; set; }
        public int Count { get { return cars.Count; } }

        public void Add(Car car)
        {
            if (!cars.Any(x => x.LicensePlate == car.LicensePlate) && Count < Capacity && car.HorsePower <= MaxHorsePower)
            {
                cars.Add(car);
            }
        }
        public bool Remove(string licensePlate)
        {
            return cars.Remove(FindParticipant(licensePlate));
        }
        public Car FindParticipant(string licensePlate)
        {
            return cars.FirstOrDefault(x => x.LicensePlate == licensePlate);
        }

        public Car GetMostPowerfulCar()
        {
            return cars.OrderBy(x => x.HorsePower).LastOrDefault();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {this.Name} - Type: {this.Type} (Laps: {this.Laps})");
            foreach (var car in this.cars)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
