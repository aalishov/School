using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Arena
{
    private readonly List<Gladiator> gladiators;

    public Arena(string name)
    {
        this.Name = name;
        this.gladiators = new List<Gladiator>();
    }

    public string Name { get; set; }

    public int Count { get => gladiators.Count; }

    public void Add(Gladiator gladiator)
    {
        this.gladiators.Add(gladiator);
    }

    public void Remove(string name)
    {
        Gladiator gladiator = this.gladiators.FirstOrDefault(x => x.Name == name);
        this.gladiators.Remove(gladiator);
    }

    public Gladiator GetGladitorWithHighestStatPower()
    {
        return this.gladiators.OrderBy(x => x.GetStatPower()).LastOrDefault();
    }
    public Gladiator GetGladitorWithHighestWeaponPower()
    {
        return this.gladiators.OrderBy(x => x.GetWeaponPower()).LastOrDefault();
    }
    public Gladiator GetGladitorWithHighestTotalPower()
    {
        return this.gladiators.OrderBy(x => x.GetTotalPower()).LastOrDefault();
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.Count} gladiators are participating.";
    }
}

