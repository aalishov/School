using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SystemManager
{
    private readonly List<Miner> miners;
    private readonly List<Provider> providers;
    private double totalEnergy = 0;
    private double totatCoalOut = 0;
    public SystemManager()
    {
        this.miners = new List<Miner>();
        this.providers = new List<Provider>();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            string type = arguments[0];
            string id = arguments[1];
            double coalOut = double.Parse(arguments[2]);
            double energyRequirement = double.Parse(arguments[3]);

            if (type == nameof(Driller))
            {
                miners.Add(new Driller(id, coalOut, energyRequirement));

            }
            else if (type == nameof(Hewer))
            {
                int enduranceFactor = int.Parse(arguments[4]);
                miners.Add(new Hewer(id, coalOut, energyRequirement, enduranceFactor));
            }

            return $"Successfully registered {type} Miner – {id}";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            string type = arguments[0];
            string id = arguments[1];
            double energyOutput = double.Parse(arguments[2]);
            if (type == "Sun")
            {
                this.providers.Add(new SunProvider(id, energyOutput));
            }
            else if (type == "Electricity")
            {
                this.providers.Add(new ElectricityProvider(id, energyOutput));
            }
            return $"Successfully registered {type} Provider – {id}";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
    public string Day()
    {
        StringBuilder sb = new StringBuilder();

        double currentEnergy = this.providers.Sum(x => x.EnergyOutput);
        this.totalEnergy += currentEnergy;
        double needed = this.miners.Sum(x => x.EnergyRequirement);
        if (totalEnergy >= needed)
        {
            totalEnergy -= needed;
            double summedCoalOutput = this.miners.Sum(x => x.CoalOutput);
            this.totatCoalOut += summedCoalOutput;
            sb.AppendLine("A day has passed");
            sb.AppendLine($"Energy Provided: {currentEnergy}");
            sb.AppendLine($"Mined Coal: {summedCoalOutput}");
            return sb.ToString().TrimEnd();
        }
        return null;
    }
    public string Check(List<string> arguments)
    {
        string id = arguments[0];
        if (this.miners.Any(x=>x.Id==id))
        {
            return this.miners.FirstOrDefault(x => x.Id == id).ToString();
        }
        else if(this.providers.Any(x=>x.Id==id))
        {
            return this.providers.FirstOrDefault(x => x.Id == id).ToString();
        }
        else
        {
            return $"No element found with id – {id}";
        }
    }
    public string ShutDown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"System Shutdown");
        sb.AppendLine($"Total Energy Stored: {totalEnergy}");
        sb.AppendLine($"Total Mined Coal: {totatCoalOut}");
        return sb.ToString();
    }

}

