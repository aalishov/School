public class Program
{
    public static void Main()
    {
        Person firstPerson = new Person()
        {
            Name = "John", 
            Age = 25
        };
        Person secondPerson = new Person()
        {
            Name = "Jane",
            Age = 16
        };
        firstPerson.Grow();
       
        Console.WriteLine(Person.Count);
    }
}
