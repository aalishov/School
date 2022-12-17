using System;
using System.Collections.Generic;
using System.Text;

public class Team
{
    private readonly List<Person> firstTeam;
    private readonly List<Person> reserveTeam;

    public Team(string name)
    {
        Name = name;
        firstTeam = new List<Person>();
        reserveTeam = new List<Person>();
    }

    public string Name { get; private set; }

    public IReadOnlyList<Person> FirstTeam { get { return firstTeam; } }
    public IReadOnlyList<Person> ReserveTeam { get { return reserveTeam; } }

    public void Add(Person person)
    {
        if (person.Age < 40)
        {
            firstTeam.Add(person);
        }
        else
        {
            reserveTeam.Add(person);
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Team: {Name}");
        sb.AppendLine($"\tFirst team players: ");
        firstTeam.ForEach(x => sb.AppendLine($"\t\t{x.ToString()}"));
        sb.AppendLine($"\tReserve team players: ");
        reserveTeam.ForEach(x => sb.AppendLine($"\t\t{x.ToString()}"));

        return sb.ToString().TrimEnd();
    }
}

