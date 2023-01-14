using System;
using System.Collections.Generic;
using System.Text;

public class Controller
{
    private Dictionary<string, Category> categories = new Dictionary<string, Category>();
    public string AddCategory(List<string> args)
    {
        string categoryName = args[1];
        if (categories.ContainsKey(categoryName))
        {
            return "This category already exist.";
        }
        categories.Add(categoryName, new Category(categoryName));
        return $"Created Category {categoryName}!";
    }

    public string AddJobOffer(List<string> args)
    {
         string name = args[1];
        string jobtitle = args[2];
        string company = args[3];
        double salary = double.Parse(args[4]);
        string type = args[5];
        JobOffer jo = null;
        switch (type)
        {
            case "onsite":
                string city = args[6];
                jo = new OnSiteJobOffer(jobtitle, company, salary, city);
                break;
            case "remote":
                bool fullyRemote = bool.Parse(args[6].ToLower());
                jo = new RemoteJobOffer(jobtitle, company, salary, fullyRemote);
                break;
        }
        if (!categories.ContainsKey(name))
        {
            return "This category doesn't exist.";
        }
        categories[name].AddJobOffer(jo);
        return $"Created JobOffer {jobtitle} in Category {name}!";
    }

    public string GetAverageSalary(List<string> args)
    {
        string name = args[1];
        if (!categories.ContainsKey(name))
        {
            return "This category doesn't exist.";
        }
        else
        {
            return $"The average salary is: {categories[name].AverageSalary():f2} BGN";
        }
    }

    public string GetOffersAboveSalary(List<string> args)
    {
        string name = args[1];
        double salary = double.Parse(args[2]);
        if (!categories.ContainsKey(name))
        {
            return "This category doesn't exist.";
        }
        StringBuilder sb = new StringBuilder();
        categories[name].GetOffersAboveSalary(salary).ForEach(x => sb.AppendLine(x.ToString()));
        return sb.ToString();
    }

    public string GetOffersWithoutSalary(List<string> args)
    {
        StringBuilder sb = new StringBuilder();
        string name = args[1];
        if (!categories.ContainsKey(name))
        {
            return "This category doesn't exist.";
        }
        categories[name].GetOffersWithoutSalary().ForEach(x => sb.AppendLine(x.ToString()));
        return sb.ToString();
       
        
    }
}

