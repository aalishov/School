using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Category
{
    private readonly List<JobOffer> jobs = new();
    private string name;

    public Category(string name)
    {
        Name = name;
    }

    public string Name
    {
        get { return name; }
        set
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
        jobs.Add(offer);
    }

    public double AverageSalary()
    {
        return jobs.Any() ? jobs.Average(x => x.Salary) : 0;
    }

    public List<JobOffer> GetOffersAboveSalary(double salary)
    {
        return jobs.Where(x => x.Salary >= salary).OrderByDescending(x=>x.Salary).ToList();
    }

    public List<JobOffer> GetOffersWithoutSalary()
    {
        return jobs.Where(x => x.Salary == 0).ToList();
    }

    public override string ToString()
    {
        return $"Category {Name}{Environment.NewLine}Total Offers: {jobs.Count}";
    }
}

