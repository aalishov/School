using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Controller
{
    private Dictionary<string, Village> villages = new Dictionary<string, Village>();
    private Dictionary<string, Rebel> rebels = new Dictionary<string, Rebel>();
    private int totalAttacksPerformed;
    public string ProcessVillageCommand(List<string> args)
    {
        string name = args[0];
        string location = args[1];
        Village village = new Village(name, location);
        villages.Add(name, village);
        return $"Created Village {name}!";
    }
    public string ProcessSettleCommand(List<string> args)
    {
        string peasantName = args[0];
        int age = int.Parse(args[1]);
        int productivity = int.Parse(args[2]);
        string villageName = args[3];
        this.villages[villageName].AddPeasant(new Peasant(peasantName, age, productivity));
        return $"Settled Peasant {peasantName} in Village {villageName}!";
    }
    public string ProcessRebelCommand(List<string> args)
    {
        string rebelName = args[0];
        int age = int.Parse(args[1]);
        int harm = int.Parse(args[2]);
        this.rebels.Add(rebelName, new Rebel(rebelName, age, harm));
        return $"Rebel {rebelName} joined the gang!";
    }
    public string ProcessDayCommand(List<string> args)
    {
        string villageName = args[0];
        int dailyResource = this.villages[villageName].PassDay();
        return $"Village {villageName} resource increased with {dailyResource}!";
    }
    public string ProcessAttackCommand(List<string> args)
    {
        int rebelCount = int.Parse(args[0]);
        string villageName = args[1];
        List<Rebel> attackers = this.rebels
            .Take(rebelCount)
            .Select(x => x.Value)
            .ToList();
        if (!attackers.Any())
        {
            return $"No rebels to perform raid...";
        }
        this.totalAttacksPerformed++;
        int harm = attackers.Sum(x => x.Harm);
        this.villages[villageName].Resource -= harm;
        List<Peasant> killed = this.villages[villageName].KillPeasants(attackers.Count / 2);
        return $"Village {villageName} lost {harm} resources and {killed.Count} peasants!";
    }
    public string ProcessInfoCommand(List<string> args)
    {
        string side = args[0];
        StringBuilder sb = new StringBuilder();
        if (side == "Rebel")
        {
            if (rebels.Count > 0)
            {
                sb.AppendLine("Rebels:");
                this.rebels
                    .Select(x => x.Value)
                    .ToList()
                    .ForEach(x => sb.AppendLine(x.ToString()));
            }
            else { sb.AppendLine("No Rebels"); }
        }
        else
        {
            if (villages.Count > 0)
            {
                sb.AppendLine("Villages:");
                this.villages
                    .Select(x => x.Value)
                    .ToList()
                    .ForEach(x => sb.AppendLine(x.ToString()));
            }
            else { sb.AppendLine("No Villages"); }
        }
        return sb.ToString().TrimEnd();
    }
    public string ProcessEndCommand()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Villages: {villages.Count}");
        sb.AppendLine($"Rebels: {rebels.Count}");
        sb.AppendLine($"Attacks on Villages: {totalAttacksPerformed}");
        return sb.ToString().TrimEnd();
    }
}

