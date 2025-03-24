public abstract class ClubMember
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public ClubMember(string firstName, string lastName, int age, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    public string FirstName
    {
        get { return firstName; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value)) {

                throw new ArgumentException("The name can’t be an empty string!");
            }
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {

                throw new ArgumentException("The name can’t be an empty string!");
            }
            lastName = value;
        }
    }

    public int Age
    {
        get { return age; }
        private set
        {
            if (value<=17)
            {

                throw new ArgumentException("Age must be greater than 17 years!");
            }
            age = value;
        }
    }

    public double Salary
    {
        get { return salary; }
        private set
        {
            if (value <=0)
            {

                throw new ArgumentException("Salary must be a positive number!");
            }
            salary = value;
        }
    }

    public abstract string Info();

}