
using System.Text;

public class Director : ClubMember
{
    public Director(string firstName, string lastName, int age, double salary, string directorType) : base(firstName, lastName, age, salary)
    {
        DirectorType = Enum.Parse<DirectorType>(directorType);
    }

    public DirectorType DirectorType { get; private set; }

    public override string Info()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Enum.GetName(DirectorType)} director: {FirstName} {LastName}");
        sb.AppendLine($"salary: {Salary:f2} lv");
        sb.AppendLine($"age: {Age} years");
        return sb.ToString().TrimEnd();
    }
}

public enum DirectorType
{
    executive = 0,
    technical = 1,
    sports = 2
}