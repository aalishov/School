using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Village
{
    private readonly List<Peasant> peasants;
    private string name;
    private string location;
    public Village(string name, string location)
    {
        this.Name = name;
        this.Location = location;
        this.peasants = new List<Peasant>();
    }
    public string Name
    {
        get { return name; }
        private set
        {
            if (value.Length < 2 || value.Length > 40)
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
            name = value;
        }
    }
    public string Location
    {
        get { return location; }
        private set
        {
            if (value.Length < 3 || value.Length > 45)
            {
                throw new ArgumentException("Location should be between 3 and 45 characters!");
            }
            location = value;
        }
    }
    public int Resource { get;  set; }
    public void AddPeasant(Peasant peasant)
    {
        this.peasants.Add(peasant);
    }
    public int PassDay()
    {
        int peasantsWork = this.peasants.Sum(x => x.Productivity);
        this.Resource += peasantsWork;
        return peasantsWork;
    }
    public List<Peasant> KillPeasants(int count)
    {
        List<Peasant> removedPeasants = this.peasants
              .Take(count)
              .ToList();
        //this.peasants.RemoveAll(x => removedPeasants.Any(y => y == x));
        foreach (var p in removedPeasants)
        {
            this.peasants.Remove(p);
        }
        return removedPeasants;
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Village - {Name} ({Location})");
        sb.AppendLine($"Resources - {Resource}");
        sb.AppendLine($"Peasants – ({this.peasants.Count})");
        foreach (var p in this.peasants)
        {
            sb.AppendLine($"{p}");
        }
        return sb.ToString().TrimEnd();
    }
}

