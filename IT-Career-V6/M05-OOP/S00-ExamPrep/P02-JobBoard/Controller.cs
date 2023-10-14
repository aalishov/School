using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;


public class Controller
{
    private readonly Dictionary<string, Category> categories = new();

    public string AddCategory(List<string> args)
    {
        string name = args[0];
        categories.Add(name, new Category(name));
        return $"Created Category {name}!";
    }

    public string AddJobOffer(List<string> args)
    {
        JobOffer offer = null;
        if (args[4] == "onsite")
        {
            offer = new OnSiteJobOffer(args[1], args[2], double.Parse(args[3]), args[5]);
        }
        else if (args[4] == "remote")
        {
            offer = new RemoteJobOffer(args[1], args[2], double.Parse(args[3]), bool.Parse(args[5]));
        }
        categories[args[0]].AddJobOffer(offer);
        return $"Created JobOffer {args[1]} in Category {args[0]}!";
    }

    public string GetAverageSalary(List<string> args)
    {
        return $"The average salary is: {categories[args[0]].AverageSalary():f2} BGN";
    }

    public string GetOffersAboveSalary(List<string> args)
    {
        List<JobOffer> offers = categories[args[0]].GetOffersAboveSalary(double.Parse(args[1]));
        StringBuilder sb = new();
        offers.ForEach(x => sb.AppendLine(x.ToString()));   
        return sb.ToString().TrimEnd(); 
    }

    public string GetOffersWithoutSalary(List<string> args)
    {
        List<JobOffer> offers = categories[args[0]].GetOffersWithoutSalary();
        StringBuilder sb = new();
        offers.ForEach(x => sb.AppendLine(x.ToString()));
        return sb.ToString().TrimEnd();
    }

}