using System;
using System.Collections.Generic;
using System.Text;

public class CompanyController
{
    private Dictionary<string, Company> companies = new Dictionary<string, Company>();
    public string CreateCompany(List<string> args)
    {
        string name = args[1];
        if (companies.ContainsKey(name))
        {
            return $"Company {name} is already registered!";
        }
        companies.Add(name, new Company(name));
        return $"Company {name} was successfully registerd in the system!";
    }
    public string RegisterBuilding(List<string> args)
    {
        string type=args[1];
        string buildingName=args[2];
        string city=args[3];
        int stars = int.Parse(args[4]);
        double rentAmount = double.Parse(args[5]);
        string companyName=args[6];
    }
    public string RegisterBroker(List<string> args)
    {
    }
    public string RentBuilding(List<string> args)
    {
    }
    public string CompanyInfo(List<string> args)
    {
    }
    public string Shutdown()
    {
    }
}

