using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_StreetRacing
{
    public class Race
    {
        private readonly List<Car> participants;
        public Race(string name, string type, int laps, int capacity, int maxHorsePower)
        {
            this.Name = name;
            this.Type = type;
            this.Laps = laps;
            this.Capacity = capacity;
            this.MaxHorsePower = maxHorsePower;
            this.participants = new List<Car>();
        }

        public string Name { get; private set; }
        public string Type { get; private set; }
        public int Laps { get; private set; }
        public int Capacity { get; private set; }
        public int MaxHorsePower { get; private set; }
        public int Count { get { return this.participants.Count; } }
        public void Add(Car car)
        {
            if (this.participants.Any(x => x.LicensePlate == car.LicensePlate)) { return; }
            if (this.Count >= this.Capacity) { return;}
            if (car.HorsePower > this.MaxHorsePower)  { return; }
            this.participants.Add(car);
        }
        public bool Remove(string licensePlate)
        {
            Car car = FindParticipant(licensePlate);
            return this.participants.Remove(car);
        }
        public Car FindParticipant(string licensePlate)
        {
            return this.participants.FirstOrDefault(x => x.LicensePlate == licensePlate);
        }
        public Car GetMostPowerfulCar()
        {
            return this.participants
                .OrderByDescending(x => x.HorsePower)
                .FirstOrDefault();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {this.Name} - Type: {this.Type} (Laps: {this.Laps})");
            foreach (var car in this.participants)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString();
        }
    }
}
