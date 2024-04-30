using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Rally
{
    private readonly List<Pilot> pilots;

    public Rally(string name, int year)
    {
        Name = name;
        Year = year;
        pilots = new List<Pilot>();
    }

    public string Name { get; set; }

    public int Year { get; set; }

    public void Add(Pilot pilot)
    {
        pilots.Add(pilot);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder($"Rally: {Name} - {Year}{Environment.NewLine}");
        pilots.ForEach(pilot => sb.AppendLine(pilot.ToString()));
        return sb.ToString().TrimEnd();
    }
}

