using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_BrokerCompanySystem
{
    public class Company
    {
        private readonly List<Building> buildings;
        private readonly List<Broker> brokers;
        private string name;

        public Company(string name)
        {
            Name = name;
            buildings= new List<Building>();
            brokers= new List<Broker>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Company name must not be null or empty!");
                }
                name = value;
            }
        }
        public void AddBroker(Broker broker)
        {
            if (!brokers.Contains(broker))
            {
                brokers.Add(broker);
            }
        }
        public void AddBuilding(Building building)
        {
            if (!buildings.Contains(building))
            {
                buildings.Add(building);
            }
        }
        public Broker GetBrokerByName(string name) 
        {
            return brokers.FirstOrDefault(b => b.Name == name);
        }
        public Building GetBuildingByName(string name) 
        {
            return buildings.FirstOrDefault(b => b.Name == name);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Company: {Name}");
            sb.AppendLine($"##Brokers: {brokers.Count}");
            brokers.ForEach(b => sb.AppendLine(b.ToString()));
            sb.AppendLine($"##Buildings: {buildings.Count}");
            buildings.ForEach(b => sb.AppendLine(b.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}
