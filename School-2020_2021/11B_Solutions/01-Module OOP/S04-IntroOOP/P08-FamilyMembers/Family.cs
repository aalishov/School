using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Family
{
    private string lastName;
    private List<Person> femilyMembers;

    public Family(string lastName)
    {
        this.LastName = lastName;
        femilyMembers = new List<Person>();
    }
    public string LastName
    {
        get { return lastName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid last name!");
            }
            lastName = value;
        }
    }

    public string AddMemebr(Person member)
    {
        this.femilyMembers.Add(member);
        return $"{member.Name} added to family {this.LastName}";
    }

    public string GetOldestMember()
    {
        Person oldestPerson = this.femilyMembers
            .OrderBy(p => p.Age)
            .LastOrDefault();
        return $"Oldest member: {oldestPerson.Name} - {oldestPerson.Age} years old";
    }
    public string GetYoungestMember()
    {
        Person oldestPerson = this.femilyMembers
            .OrderBy(p => p.Age)
            .FirstOrDefault();
        return $"Youngest member: {oldestPerson.Name} - {oldestPerson.Age} years old";
    }

    public void Grow()
    {
        foreach (var member in this.femilyMembers)
        {
            member.Grow();
        }
    }

    public string PrintFamilyInfo()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{new string('-',50)}");
        sb.AppendLine($"Family - {this.LastName}");

        foreach (var member in femilyMembers)
        {
            sb.AppendLine($"=> {member.ToString()}");
        }
        sb.AppendLine($"{new string('-', 50)}");
        return sb.ToString().TrimEnd();
    }
}

