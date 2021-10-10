using System;
using System.Text;

public class Miner
{
    private double coalOut;
    private double energyRequirement;

    public Miner(string id, double coalOut, double energyRequirement)
    {
        this.Id = id;
        this.CoalOutput = coalOut;
        this.EnergyRequirement = energyRequirement;
    }

    public string Id { get; set; }

    public double CoalOutput
    {
        get { return coalOut; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Miner is not registered, because of it's {nameof(CoalOutput)}");
            }
            coalOut = value;
        }
    }

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        set
        {
            if (value < 0 || value > 20000)
            {
                throw new ArgumentException($"Miner is not registered, because of it's {nameof(EnergyRequirement)}");
            }
            energyRequirement = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.GetType().Name} Miner - {this.Id}");
        sb.AppendLine($"Coal Output: {this.CoalOutput}");
        sb.AppendLine($"Energy Requirement: {this.EnergyRequirement}");
        return sb.ToString().TrimEnd() ;
    }
}

