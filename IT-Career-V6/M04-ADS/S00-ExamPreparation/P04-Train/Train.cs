public class Train
{
    public Train(int number, string name, string type, int cars)
    {
        Number = number;
        Name = name;
        Type = type;
        Cars = cars;
    }

    public int Number { get; private set; }

    public string Name { get; private set; }

    public string Type { get; private set; }

    public int Cars { get; private set; }

    public override string ToString()
    {
        return $"{Number} {Name} {Type}"; 
    }
}

