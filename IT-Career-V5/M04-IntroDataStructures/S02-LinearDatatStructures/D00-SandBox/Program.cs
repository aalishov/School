
Dog dog = new Dog();
dog.Name = "Sharo";
dog.Bark();

class House
{
    private readonly List<Person> people;

}


class Dog
{
    public string Name { get; set; }
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}
class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
class Ticket
{
    public Person Person { get; set; }
    public string Number { get; set; }
}