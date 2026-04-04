public class Person
{
    //Fields
    private string name;

    //Constructors
    public Person() { }

    public Person(string name)
    {
        this.Name = name;
    }

    public Person(string name, int age) : this(name)
    {
        this.Age = age;
    }

    //Properties
    public string Name
    {
        get
        {
            if (string.IsNullOrWhiteSpace(this.name))
            {
                return "No name";
            }
            return this.name;
        }
        private set
        {
            if (value.Length < 3 || !char.IsUpper(value[0]))
            {
                throw new ArgumentException("Invalid name");
            }
            this.name = value;
        }
    }

    public int Age { get; set; }

    //Methods
    public void ChangeName(string newName)
    {
        this.Name = newName;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello, my name is {this.Name} and I am {this.Age} years old.");
    }
}

