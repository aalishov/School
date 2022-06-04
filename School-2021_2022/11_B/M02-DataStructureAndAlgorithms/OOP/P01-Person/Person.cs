public class Person
{
    public static int Count { get; set; }
    public Person()
    {
        Count++;
    }
    public string Name { get; set; }
    public int Age { get; set; }

    public void Grow()
    {
        Age++;
    }
}

