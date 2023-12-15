using System.Linq;
using System.Text;

public class Category
{
    private readonly List<JobOffer> offers;
    private string name;

    public Category(string name)
    {
        Name = name;
        offers = new();
    }

    public string Name
    {
        get => name;
        private set
        {
            if (value.Length < 2 || value.Length > 40)
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
            name = value;
        }
    }

    public void AddJobOffer(JobOffer offer)
    {
        offers.Add(offer);
    }
    public double AverageSalary()
    {
        double averageSalary = offers.Count != 0 ? offers.Average(offer => offer.Salary) : 0;
        return averageSalary;
    }
    public List<JobOffer> GetOffersAboveSalary(double salary)
    {
        List<JobOffer> sortedOffers = offers.Where(x => x.Salary >= salary).OrderByDescending(x => x.Salary).ToList();
        return sortedOffers;
    }
    public List<JobOffer> GetOffersWithoutSalary(double salary)
    {
        List<JobOffer> sortedOffers = offers.Where(x => x.Salary <= 0).ToList();
        return sortedOffers;
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine($"Category: {Name}");
        sb.AppendLine($"Total Offers: {offers.Count}");
        return sb.ToString().TrimEnd();

    }
}

