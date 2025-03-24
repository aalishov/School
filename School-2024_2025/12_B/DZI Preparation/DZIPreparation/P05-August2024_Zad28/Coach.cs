
using System.Text;

public class Coach : ClubMember
{
    public Coach(string firstName, string lastName, int age, double salary, string coachType, int contractLength) : base(firstName, lastName, age, salary)
    {
        CoachType = Enum.Parse<CoachType>(coachType);
        ContractLength = contractLength;
    }

    public CoachType CoachType { get; private set; }

    public int ContractLength { get; private set; }
    public override string Info()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{Enum.GetName(CoachType)} coach: {FirstName} {LastName}");
        sb.AppendLine($"salary: {Salary:f2} lv");
        sb.AppendLine($"age: {Age} years");
        return sb.ToString().TrimEnd();
    }
}

public enum CoachType
{
    head = 0,
    assistant = 1,
    goalkeeper = 2
}