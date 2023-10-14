using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class JobOffer
{
    private string jobTitle;
    private string company;
    private double salary;

    protected JobOffer(string jobTitle, string company, double salary)
    {
        JobTitle = jobTitle;
        Company = company;
        Salary = salary;
    }

    public string JobTitle
    {
        get { return jobTitle; }
        private set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("JobTitle should be between 3 and 30 characters!");
            }
            jobTitle = value;
        }
    }
    public string Company
    {
        get { return company; }
        private set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Company should be between 3 and 30 characters!");
            }
            company = value;
        }
    }
    public double Salary
    {
        get { return salary; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Salary should be 0 or positive!");
            }
            salary = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Job Title: {JobTitle}");
        sb.AppendLine($"Company: {Company}");
        sb.AppendLine($"Salary: {Salary:F2} BGN");
        return sb.ToString().TrimEnd();
    }
}

