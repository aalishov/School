public class Program
{
    public static void Main()
    {
        //Coffee, Espresso, Medium, Strong, 3.5 
        //Tea, Green Tea, Medium, Green, 2.5
        //Coffee, Cappuccino, Medium, Medium, 3.5
        try
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(", ");
                Drink drink = null;
                if (input[0] == nameof(Tea))
                {
                    drink = new Tea(input[1], double.Parse(input[4]), Enum.Parse<Size>(input[2]), Enum.Parse<Type>(input[3]));
                }
                else if (input[0] == nameof(Coffee))
                {
                    drink = new Coffee(input[1], double.Parse(input[4]), Enum.Parse<Size>(input[2]), Enum.Parse<Strength>(input[3]));
                }
                else
                {
                    Environment.Exit(0);
                }
                Console.WriteLine(drink);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public class Tea : Drink
{
    public Tea(string name, double price, Size size, Type type) : base(name, price, size)
    {
        Type = type;
    }

    public Type Type { get; private set; }

    public override string ToString()
    {
        return $"Cofee: {Name}, Size: {Size}, Type: {Type}, Price: {Price:f2}";
    }
}
public class Coffee : Drink
{
    public Coffee(string name, double price, Size size, Strength strength) : base(name, price, size)
    {
        Strength = strength;
    }

    public Strength Strength { get; private set; }

    public override string ToString()
    {
        return $"Cofee: {Name}, Size: {Size}, Strength: {Strength}, Price: {Price:f2}";
    }
}

public abstract class Drink
{
    public Drink(string name, double price, Size size)
    {
        Name = name;
        Price = price;
        Size = size;
    }

    public string Name { get; private set; }

    public double Price { get; private set; }

    public Size Size { get; private set; }
}

public enum Size
{
    Small = 0,
    Medium = 1,
    Large = 2,
}
public enum Strength
{
    Light = 0,
    Medium = 1,
    Strong = 2,
}

public enum Type
{
    Green = 0,
    Black = 1,
    Herbal = 2,
}