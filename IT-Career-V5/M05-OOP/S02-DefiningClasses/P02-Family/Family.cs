using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Family
{
    private readonly List<Person> people = new List<Person>();

    public IReadOnlyCollection<Person> People { get { return this.people.AsReadOnly(); } }

    public void AddMember(Person person)
    {
        this.people.Add(person);
    }
    public string Report()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Family count: {this.People.Count}");
        foreach (var person in this.People.OrderBy(x=>x.Name))
        {
            sb.AppendLine($"\t{person.ToString()}");
        }
        return sb.ToString().TrimEnd();
    }
}

