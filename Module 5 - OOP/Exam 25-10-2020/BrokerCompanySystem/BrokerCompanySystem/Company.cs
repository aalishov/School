using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;


public class Company
{
    private readonly List<Building> buildings;

    private readonly List<Broker> brokers;
    private string name;

    public Company(string name)
    {
        this.Name = name;
        this.buildings = new List<Building>();
        this.brokers = new List<Broker>();
    }

    public string Name
    {
        get { return name; }
        private set
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
        if (!brokers.Any(x => x.Name == broker.Name))
        {
            this.brokers.Add(broker);
        }
    }

    public void AddBuilding(Building building)
    {
        if (!buildings.Any(x => x.Name == building.Name))
        {
            this.buildings.Add(building);
        }
    }

    public Broker GetBrokerByName(string name)
    {
        return brokers.FirstOrDefault(x => x.Name == name);
    }

    public Building GetBuildingByName(string name)
    {
        return buildings.FirstOrDefault(x => x.Name == name);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Company: {this.Name}");
        sb.AppendLine($"##Brokers: {this.brokers.Count}");
        foreach (var b in brokers)
        {
            sb.AppendLine(b.ToString());
        }
        sb.AppendLine($"##Buildings: {this.buildings.Count}");
        foreach (var b in buildings)
        {
            sb.AppendLine(b.ToString());
        }
        return sb.ToString().TrimEnd();
    }
}
