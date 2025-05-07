using System.Text;

public class Rally
{
    private List<Pilot> pilots;
    public Rally(string name, int year)
    {
        Name = name;
        Year = year;
        this.pilots = new List<Pilot>();
    }
    public string Name { get; set; }
    public int Year { get; set; }
    public bool RemovePilot(string name)
    {
        Pilot pilot = this.pilots.FirstOrDefault(x => x.Name == name);
        return pilots.Remove(pilot);
    }
    public void AddPilot(Pilot pilot)
    {
        pilots.Add(pilot);
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Rally: {Name} - {Year}");
        foreach (Pilot pilot in pilots)
        {
            sb.AppendLine(pilot.ToString());
        }
        return sb.ToString().TrimEnd();
    }
}

