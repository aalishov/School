using System;
using System.Collections.Generic;
using System.Text;

public class Spy : SpecializedSoldier, ISpy
{
    public Spy(int id, string firstName, string lastName, Corp corp) : base(id, firstName, lastName, corp)
    {
    }

    public int CodeNumber { get; private set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
        sb.AppendLine($"Code Number: {CodeNumber}");
        return sb.ToString();
    }
}
