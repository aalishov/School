
public class Person
{
    protected int age;

    public Person(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public string Name { get; set; }

    public string Address { get; set; }

    public virtual string GetNameAndAddress()
    {
        return $"Name: {Name}, address: {Address}, {this.GetType().Name.ToLower()}";
    }
}

