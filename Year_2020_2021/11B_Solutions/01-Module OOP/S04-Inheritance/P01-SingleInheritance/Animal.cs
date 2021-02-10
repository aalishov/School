public class Animal
{
    public string Name { get; set; }

    public int Age { get; set; }

    public string Eat()
    {
        return "Eating...";
    }

    public override string ToString()
    {
        return base.ToString() + $" => Name: {this.Name}, age: {this.Age}";
    }
}

