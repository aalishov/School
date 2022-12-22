using System;
using System.Collections.Generic;
using System.Text;

public class SpecializedSoldier : Soldier, ISpecializedSoldier
{
    public SpecializedSoldier(int id, string firstName, string lastName, Corp corp) : base(id, firstName, lastName)
    {
        this.Corp = corp;
    }
    public Corp Corp { get; private set; }
}
