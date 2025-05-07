
using System.Collections;

public class House : IEnumerable<Person>
{
    private readonly List<Person> people;

    public House(int capacity)
    {
        MaxCapacity = capacity;
        people = new List<Person>();
    }

    public int MaxCapacity { get; set; }

    public void Add(Person person)
    {
        if (people.Count < MaxCapacity)
        {
            people.Add(person);
        }
    }

    public IEnumerator<Person> GetEnumerator()
    {
        return this.people.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

