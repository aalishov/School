public class Pilot : Person
{
    public Pilot(string name, int age, Car carP, string category) : base(name, age)
    {
        CarP = carP;
        Category = category;
    }
    public Car CarP { get; set; }
    public string Category { get; set; }
    public override string ToString()
    {
        return $"{Name}, {Age}, {Category}, {CarP.Brand}, {CarP.HPower}";
    }
}

