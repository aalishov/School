public class Employee : Person
{
    public Employee(string name, string address, string company) : base(name, address)
    {
        this.Company = company;
    }

    public string Company { get; set; }

    public override string GetNameAndAddress()
    {
        return $"{base.GetNameAndAddress()}, company: {Company}";
    }
}

