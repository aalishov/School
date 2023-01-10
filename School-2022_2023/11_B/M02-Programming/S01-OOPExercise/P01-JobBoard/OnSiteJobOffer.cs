using System;
using System.Collections.Generic;
using System.Text;

public class OnSiteJobOffer : JobOffer
{
    public OnSiteJobOffer(string jobTitle, string company, double salary, string city) : base(jobTitle, company, salary)
    {
        this.City = city;
    }
    private string city;

    public string City
    {
        get { return city; }
        set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("City should be between 3 and 30 characters!");
            }
            city = value;
        }
    }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine($"City: {City}");
        return sb.ToString().TrimEnd();
    }
}

