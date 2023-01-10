using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Category
{
    private string name;
    private readonly List<JobOffer> jobOffers;

    public Category(string name)
    {
        Name = name;
        jobOffers = new List<JobOffer>();
    }

    public string Name
    {
        get { return name; }
        private set
        { 
            if (value.Length<2 || value.Length>40 )
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }
            name = value;
        }
    }
    public void AddJobOffer(JobOffer offer)
    {
        jobOffers.Add(offer);
    }
    public double AverageSalary()
    {
        return jobOffers.Average(x => x.Salary);
    }
    public List<JobOffer> GetOffersAboveSalary(double salary)
    {
        return jobOffers.Where(x => x.Salary >= salary).OrderByDescending(x => x.Salary).ToList();
    }
    public List<JobOffer> GetOffersWithoutSalary()
    {
        return jobOffers.Where(x => x.Salary == 0).OrderBy(x => x.Company).ToList();
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Category {this.Name}");
        sb.AppendLine($"Total Offers: {jobOffers.Count}");

        return sb.ToString();
    }
}

