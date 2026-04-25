public class Person
{
    private const double MinSalary = 460;

    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age, double salary = MinSalary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    //immutable class - all properties are read-only and set through the constructor
    public string FirstName
    {
        get { return firstName; }

        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("First name cannot be less than 3 symbols");
            }
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }

        private set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Last name cannot be less than 3 symbols");
            }
            lastName = value;
        }
    }

    public int Age
    {
        get { return age; }

        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age cannot be zero or negative integer");
            }
            age = value;
        }
    }

    public double Salary
    {
        get { return salary; }

        private set
        {
            if (value < MinSalary)
            {
                throw new ArgumentException($"Salary cannot be less than {MinSalary}€ ");
            }
            salary = value;
        }
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} get {Salary}€";
    }
}

