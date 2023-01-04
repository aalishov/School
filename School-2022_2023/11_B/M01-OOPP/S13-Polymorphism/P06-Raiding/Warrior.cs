using System;
using System.Collections.Generic;
using System.Text;

public class Warrior : BaseHero
{
    public Warrior(string name) : base(name, 100)
    {
    }
    public override string CastAbility()
    {
        return $"{GetType().Name} - {Name} hit for {Power} damage";
    }
}

