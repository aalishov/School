namespace P01_Openning
{
    public class Employee
    {
        public Employee(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Employee: {this.Name}, {this.Age} ({this.Country})";
        }
    }
}
