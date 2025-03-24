
using System.Text;

public class FootballPlayer : ClubMember
{
    public FootballPlayer(string firstName, string lastName, int age, double salary, string position, int contractLength, int matches, int goals, int assist) : base(firstName, lastName, age, salary)
    {
        Position = Enum.Parse<Position>(position);
        ContractLength = contractLength;
        Matches = matches;
        Goals = goals;
        Assist = assist;
    }

    public Position Position { get; private set; }

    public int ContractLength { get; private set; }

    public int Matches { get; private set; }

    public int Goals { get; private set; }

    public int Assist { get; private set; }

    public override string Info()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{FirstName} {LastName} - {Enum.GetName(Position)}");
        sb.AppendLine($"salary: {Salary:f2} lv");
        sb.AppendLine($"age: {Age} years");
        sb.AppendLine($"{Goals} goals and {Assist} assists in {Matches} matches");
        return sb.ToString().TrimEnd();
    }
}

public enum Position
{
    forward = 0,
    midfielder = 1,
    defender = 2,
    goalkeeper = 3
}