using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class OnSiteJobOffer : JobOffer
{
    private string city;

    public OnSiteJobOffer(string jobTitle, string company, double salary,string city) : base(jobTitle, company, salary)
    {
        City = city;
    }

    public string City
    {
        get { return city; }
        set
        {
            if (value.Length<3||value.Length>30)
            {
                throw new ArgumentException("City should be between 3 and 30 characters!");
            }
            city = value;
        }
    }

    public override string ToString()
    {
        return base.ToString()+$"{Environment.NewLine}City: {City}";
    }
}

