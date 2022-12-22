using System;
using System.Collections.Generic;
using System.Text;

public class LieutenantGeneral : Private, ILieutenantGeneral
{
    private readonly List<Private> privates;
    public LieutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
    {
        this.privates = new List<Private>();
    }
    public IReadOnlyList<Private> Privates { get { return privates; } }
    public void Add(Private p)
    {
        privates.Add(p);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine("Privates:");
        this.privates.ForEach(x => sb.AppendLine("\t" + x.ToString()));
        return sb.ToString();
    }
}
