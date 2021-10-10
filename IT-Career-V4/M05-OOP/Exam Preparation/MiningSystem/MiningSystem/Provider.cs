using System;
using System.Text;

public class Provider
{
    private double energyOutput;
    public Provider(string id, double energyOutput)
    {
        Id = id;
        EnergyOutput = energyOutput;
    }
    public string Id { get; set; }
    public double EnergyOutput
    {
        get { return energyOutput; }
        set
        {
            if (value <= 0||value>=10000)
            {
                throw new ArgumentException($"Provider is not registered, because of it's {nameof(EnergyOutput)}");
            }
            energyOutput = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.GetType().Name} Provider - {this.Id}");
        sb.AppendLine($"Energy Output: {this.EnergyOutput}");
        return sb.ToString().TrimEnd();
    }
}

