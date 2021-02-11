namespace BrokerCompany.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using BrokerCompany.Common;

    public class Company : ICompany
    {
        private readonly ICollection<IBuilding> buildings;
        private readonly ICollection<IBroker> brokers;
        private string name;

        public Company(string name)
        {
            this.Name = name;
            this.buildings = new List<IBuilding>();
            this.brokers = new List<IBroker>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(string.Format(ModelsSM.InvalidNameValue, nameof(Company)));
                }

                this.name = value;
            }
        }

        public void AddBroker(IBroker broker)
        {
            if (!this.brokers.Any(x => x.Name == broker.Name))
            {
                this.brokers.Add(broker);
            }
        }

        public void AddBuilding(IBuilding building)
        {
            if (!this.buildings.Any(x => x.Name == x.Name))
            {
                this.buildings.Add(building);
            }
        }

        public IBroker GetBrokerByName(string name)
        {
            return this.brokers.FirstOrDefault(x => x.Name == name);
        }

        public IBuilding GetBuildingByName(string name)
        {
            return this.buildings.FirstOrDefault(x => x.Name == name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format(ModelsSM.CompanyName, this.Name));
            sb.AppendLine(string.Format(ModelsSM.CompanyBrokersCount, this.brokers.Count));
            foreach (var broker in this.brokers)
            {
                sb.AppendLine(broker.ToString());
            }

            sb.AppendLine(string.Format(ModelsSM.CompanyBuildingsCount, this.buildings.Count));
            foreach (var building in this.buildings)
            {
                sb.AppendLine(building.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
