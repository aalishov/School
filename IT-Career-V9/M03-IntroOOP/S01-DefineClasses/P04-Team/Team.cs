
public class Team
{
    private readonly List<Person> firstTeam;
    private readonly List<Person> secondTeam;

    public Team(string name)
    {
        Name = name;
        firstTeam = new List<Person>();
        secondTeam = new List<Person>();
    }

    public string Name { get; set; }

    public IReadOnlyCollection<Person> FirstTeam { get { return firstTeam.AsReadOnly(); } }

    public IReadOnlyCollection<Person> SecondTeam { get { return secondTeam.AsReadOnly(); } }

    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
        {
            firstTeam.Add(person);
        }
        else
        {
            secondTeam.Add(person);
        }
    }
}

