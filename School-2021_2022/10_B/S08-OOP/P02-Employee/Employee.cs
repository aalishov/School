public class Employee
{
    public Employee(string firstName, string lastName, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public double Salary { get; private set; }

    public void ChangeFirstName(string newName)
    {
        FirstName = newName;
    }
    public void IncreaseSalary()
    {
        Salary *= 1.1;
    }

    public override string ToString()
    {
        return $"Employee: {FirstName} {LastName}, salary: {Salary:f2}";
    }
}

