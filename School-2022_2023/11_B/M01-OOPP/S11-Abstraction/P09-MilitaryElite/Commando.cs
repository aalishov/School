using System;
using System.Collections.Generic;
using System.Text;

public class Commando : SpecializedSoldier, ICommando
{
    private readonly List<Mission> missions;

    public Commando(int id, string firstName, string lastName, Corp corp) : base(id, firstName, lastName, corp)
    {
        missions = new List<Mission>();
    }

    public IReadOnlyCollection<Mission> Missions { get { return missions; } }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine("Corps: " + Corp.ToString());
        sb.AppendLine("Missions:");
        this.missions.ForEach(x => sb.AppendLine("\t" + x.ToString()));
        return sb.ToString();
    }
}
