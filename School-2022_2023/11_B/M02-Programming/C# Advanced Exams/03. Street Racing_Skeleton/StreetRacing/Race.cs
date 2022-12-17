using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StreetRacing
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
        public IReadOnlyCollection<Car> Participants { get { return this.Participants; } }
        public void Add(Car car)
        {
            if (this.participants.Any(x => x.LicensePlate == car.LicensePlate))
            {
                return;
            }
            if (this.Capacity <= participants.Count)
            {
                return;
            }
            if (this.MaxHorsePower < car.HorsePower)
            {
                return;
            }
            participants.Add(car);
        }
        public bool Remove(string licensePlate)
        {
            return this.participants.Remove(FindParticipant(licensePlate));
        }
        public Car FindParticipant(string licensePlate)
        {
            return participants.FirstOrDefault(x => x.LicensePlate == licensePlate);
        }
        public Car GetMostPowerfulCar()
        {
            return participants.OrderBy(x => x.HorsePower).LastOrDefault();
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Race: {Name} - Type: {Type} (Laps: {Laps}");
            foreach (var car in participants)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        } 
    }
}
