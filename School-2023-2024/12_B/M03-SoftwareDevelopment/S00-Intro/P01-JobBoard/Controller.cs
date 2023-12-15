using System.Text;

public class Controller
{
    private readonly Dictionary<string, Category> categories = new();
    public string AddCategory(List<string> args)
    {
        categories.Add(args[0], new Category(args[0]));
        return $"Created Category {args[0]}!";
    }

    public string AddJobOffer(List<string> args)
    {

        JobOffer? offer = null;
        if (args[4] == "onsite")
        {
            offer = new OnSiteJobOffer(args[5], args[1], args[2], double.Parse(args[3]));
        }
        else
        {
            offer = new RemoteJobOffer(args[1], args[2], double.Parse(args[3]), bool.Parse(args[5]));
        }
        categories[args[0]].AddJobOffer(offer);
        return $"Created JobOffer {offer.JobTitle} in Category {args[0]}!";

    }

    public string GetAverageSalary(List<string> args)
    {

        return $"The average salary is: {categories[args[0]].AverageSalary():f2} BGN";
    }

    public string GetOffersAboveSalary(List<string> args)
    {
        StringBuilder sb = new();
        foreach (var item in categories[args[0]].GetOffersAboveSalary(double.Parse(args[1])))
        {

            sb.AppendLine(item.ToString());

        }
        return sb.ToString().TrimEnd();

    }

    public string GetOffersWithoutSalary(List<string> args)
    {
        StringBuilder sb = new StringBuilder();
        foreach (var item in categories[args[0]].GetOffersWithoutSalary(double.Parse(args[1])))
        {

            sb.AppendLine(item.ToString());

        }
        return sb.ToString().TrimEnd();
    }
}