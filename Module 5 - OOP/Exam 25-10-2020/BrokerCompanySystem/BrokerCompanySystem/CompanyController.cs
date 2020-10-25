using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CompanyController
{
    private readonly List<Company> companies;

    public CompanyController()
    {
        this.companies = new List<Company>();
    }

    public string CreateCompany(List<string> args)
    {
        try
        {
            if (companies.Any(x=>x.Name==args[1]))
            {
                return $"Company {args[1]} is already registered!";
            }
            companies.Add(new Company(args[1]));
            return $"Company {args[1]} was successfully registerd in the system!";
        }
        catch (Exception ex)
        {

            return ex.Message;
        }

    }
    public string RegisterBuilding(List<string> args)

    {
        try
        {
            string type = args[1];
            string name = args[2];
            string city = args[3];
            int stars = int.Parse(args[4]);
            double rentAmount = double.Parse(args[5]);
            string companyName = args[6];

            Company company = companies.FirstOrDefault(x => x.Name == companyName);
   
            if (company != null)
            {
                if (company.GetBuildingByName(name) != null)
                {
                    return $"Building {name} is already registered in Deager!";
                }
                switch (type)
                {
                    case "Hotel":
                        company.AddBuilding(new Hotel(name, city, stars, rentAmount));
                        break;
                    case "Residence":
                        company.AddBuilding(new Residence(name, city, stars, rentAmount));
                        break;
                    case "Business":
                        company.AddBuilding(new Business(name, city, stars, rentAmount));
                        break;
                }
                return $"Building {name} was successfully registerd in {companyName} catalog!";
            }
            return $"Invalid Company: {companyName}. Cannot find it in system!";
        }
        catch (Exception ex)
        {

            return ex.Message;
        }

    }

    public string RegisterBroker(List<string> args)

    {

        string name = args[1];
        int age = int.Parse(args[2]);
        string city = args[3];
        string companyName = args[4];

        try
        {
            Company company = companies.FirstOrDefault(x => x.Name == companyName);
            if (company != null)
            {
                if (company.GetBrokerByName(name)!=null)
                {
                    return $"Broker {name} is already part of Deager!";
                }
                company.AddBroker(new Broker(name, age, city));
                return $"Broker {name} was successfully hired in {company.Name}!";
            }
            return $"Invalid Company: {companyName}. Cannot find it in system!";
        }
        catch (Exception ex)
        {

            return ex.Message;
        }

    }

    public string RentBuilding(List<string> args)


    {
        string companyName = args[1];
        string buildingName = args[2];
        string brokerName = args[3];

        try
        {

            Company company = companies.FirstOrDefault(x => x.Name == companyName);
            if (company == null)
            {
                return $"Invalid Company: {companyName}. Cannot find it in system!";
            }
            Building building = company.GetBuildingByName(buildingName);
            if (building == null)
            {
                return $"Invalid Building: {buildingName}. Cannot find it in {companyName} catalog!";
            }
            if (!building.IsAvailable)
            {
                return $"Building: {buildingName} cannot be rented!";
            }
            Broker broker = company.GetBrokerByName(brokerName);
            if (broker == null)
            {
                return $"Invalid Broker: {brokerName}. Cannot find employee in {companyName}!";
            }

            building.IsAvailable = false;
            double bonus = broker.ReceiveBonus(building);
            //Successfully rented Heaven Business!
            //Broker Sade earned 8000!
            return $"Successfully rented {building.Name}!\nBroker {broker.Name} earned {bonus}!";
        }
        catch (Exception ex)
        {
            return ex.Message;
        }

    }

    public string CompanyInfo(List<string> args)
    {
        Company company = companies.FirstOrDefault(x => x.Name == args[1]);
        if (company!=null)
        {
            return company.ToString();
        }
        return$"Invalid Company: {args[1]}. Cannot find it in system!";
        
    }


    public string Shutdown()

    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Companies: {companies.Count}");
        foreach (var c in companies.OrderBy(x => x.Name))
        {
            sb.AppendLine(c.ToString());
        }
        return sb.ToString().TrimEnd();
    }
}
