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
        string name = args[0];

        if (companies.Any(x => x.Name == name))
        {
            return $"Company {name} is already registered!";
        }
        companies.Add(new Company(name));
        return $"Company {name} was successfully registerd in the system!";

    }
    public string RegisterBuilding(List<string> args)

    {

        string type = args[0];
        string name = args[1];
        string city = args[2];
        int stars = int.Parse(args[3]);
        double rentAmount = double.Parse(args[4]);
        string companyName = args[5];

        Company company = companies.FirstOrDefault(x => x.Name == companyName);

        if (company != null)
        {
            if (company.GetBuildingByName(name) != null)
            {
                return $"Building {name} is already registered in {companyName}!";
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

    public string RegisterBroker(List<string> args)
    {
        string name = args[0];
        int age = int.Parse(args[1]);
        string city = args[2];
        string companyName = args[3];

        Company company = companies.FirstOrDefault(x => x.Name == companyName);
        if (company != null)
        {
            if (company.GetBrokerByName(name) != null)
            {
                return $"Broker {name} is already part of {companyName}!";
            }
            company.AddBroker(new Broker(name, age, city));
            return $"Broker {name} was successfully hired in {companyName}!";
        }
        return $"Invalid Company: {companyName}. Cannot find it in system!";


    }

    public string RentBuilding(List<string> args)
    {
        string companyName = args[0];
        string buildingName = args[1];
        string brokerName = args[2];

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
        return $"Successfully rented {building.Name}!\nBroker {broker.Name} earned {bonus:f0}!";

    }

    public string CompanyInfo(List<string> args)
    {
        string name = args[0];
        Company company = companies.FirstOrDefault(x => x.Name == name);
        if (company != null)
        {
            return company.ToString();
        }
        return $"Invalid Company: {name}. Cannot find it in system!";

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
