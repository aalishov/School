public class Program
{
    public static void Main()
    {
        string[] lines = File.ReadAllLines("input.txt");

        List<ClubMember> members = new List<ClubMember>();

        foreach (var line in lines)
        {
            string[] info = line.Split(" ");

            string type = info[0];

            try
            {
                switch (type)
                {
                    case nameof(Coach):

                        members.Add(new Coach(info[1], info[2], int.Parse(info[3]), double.Parse(info[4]), info[5], int.Parse(info[6])));
                        break;
                    case nameof(Director):
                        members.Add(new Director(info[1], info[2], int.Parse(info[3]), double.Parse(info[4]), info[5]));
                        break;
                    case nameof(FootballPlayer):
                        members.Add(new FootballPlayer(info[1], info[2], int.Parse(info[3]), double.Parse(info[4]), info[5], int.Parse(info[6]), int.Parse(info[7]), int.Parse(info[8]), int.Parse(info[9])));
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Environment.Exit(0);
            }
        }

        try
        {
            foreach (var member in members.OrderBy(x => x.Age))
            {
                Console.WriteLine(member.Info());
                Console.WriteLine(new string('*', 20));
            }

            ClubMember topPayed = members.OrderBy(x => x.Salary).LastOrDefault();

            Console.WriteLine($"The person with the highest salary in the club is {topPayed.FirstName} {topPayed.LastName} with {topPayed.Salary:f2} lv salary.");

            FootballPlayer topScorrer = (FootballPlayer)(members
                .Where(x => x.GetType() == typeof(FootballPlayer))
                .OrderBy(x => ((FootballPlayer)x).Goals)
                .LastOrDefault());

            Console.WriteLine($"The team's top scorer is {topScorrer.FirstName} {topScorrer.LastName} with {topScorrer.Goals} goals.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}