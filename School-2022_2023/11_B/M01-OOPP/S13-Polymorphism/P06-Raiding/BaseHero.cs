using System;
using System.Collections.Generic;
using System.Text;

public abstract class BaseHero
{
    protected BaseHero(string name, int power)
    {
        this.Name = name;
        this.Power = power;
    }

    public string Name { get;private set; }
    public int Power { get;private set; }
    public virtual string CastAbility()
    {
        return $"{GetType().Name} - {Name} healed for {Power}";
    }

}

