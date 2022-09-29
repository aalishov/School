// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(new Car(1, "Audi"));

void Print()
{

}

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

}
class Car
{
    public Car(int id, string model)
    {
        Id = id;
        Model = model;
    }

    public int Id { get; set; }
    public string Model { get; set; }

}