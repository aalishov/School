﻿using System;
using System.Collections.Generic;
using System.Text;

public class Rogue : BaseHero
{
    public Rogue(string name) : base(name, 80)
    {
    }
    public override string CastAbility()
    {
        return $"{GetType().Name} - {Name} hit for {Power} damage";
    }
}

