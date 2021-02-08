namespace BrokerCompany.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BrokerCompany.Common;

    public class Broker
    {
        private ICollection<IBuilding> buildings;
        private string name;
        private int age;
        private string city;

        public Broker(string name, int age, string city)
        {
            this.Name = name;
            this.Age = age;
            this.City = city;
            this.buildings = new List<IBuilding>();
        }

        public string Name
        {
            get
            {
                return
                    this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(StaticMessages.InvalidNameValue, nameof(Broker)));
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < 16 || value > 70)
                {
                    throw new ArgumentException(StaticMessages.BrokerInvalidAge);
                }

                this.age = value;
            }
        }

        public string City
        {
            get
            {
                return this.city;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(StaticMessages.CityInvalidNameValue);
                }

                this.city = value;
            }
        }

        public double Bonus { get; private set; }

        public double ReceiveBonus(Building building)
        {
            this.buildings.Add(building);
            double calculateBonus = building.RentAmount * 2 * building.Stars / 100.0;
            this.Bonus += calculateBonus;
            return calculateBonus;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format(StaticMessages.BrokerNameAndAge, this.Name, this.Age));
            sb.AppendLine(string.Format(StaticMessages.Location, this.City));
            sb.AppendLine(string.Format(StaticMessages.BrokerBonus, this.Bonus));
            foreach (var building in this.buildings)
            {
                sb.AppendLine(building.Name);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
