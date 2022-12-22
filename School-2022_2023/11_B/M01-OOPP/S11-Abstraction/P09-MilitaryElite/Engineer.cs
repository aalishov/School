using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecializedSoldier, IEngineer
{
    private readonly List<Repair> repairs;

    public Engineer(int id, string firstName, string lastName, Corp corp) : base(id, firstName, lastName, corp)
    {
        this.repairs = new List<Repair>();
    }

    public IReadOnlyCollection<Repair> IReadOnlyEngineers
    {
        get { return repairs; }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine("Corps: " + Corp.ToString());
        sb.AppendLine("Repairs:");
        repairs.ForEach(x => sb.AppendLine("\t" + x.ToString()));
        return sb.ToString();
    }
}
