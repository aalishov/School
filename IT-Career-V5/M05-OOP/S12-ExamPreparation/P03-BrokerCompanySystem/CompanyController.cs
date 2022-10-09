using System;
using System.Collections.Generic;
using System.Text;

public class CompanyController
{
    private SortedDictionary<string, Company> companies = new SortedDictionary<string, Company>();
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
        string type = args[1];
        string buildingName = args[2];
        string city = args[3];
        int stars = int.Parse(args[4]);
        double rentAmount = double.Parse(args[5]);
        string companyName = args[6];

        if (!companies.ContainsKey(companyName))
        {
            return $"Invalid Company: {companyName}. Cannot find it in system!";
        }
        else if (companies[companyName].GetBuildingByName(buildingName) != null)
        {
            return $"Building {buildingName} is already registered in {companyName}!";
        }
        Building building = null;
        switch (type)
        {
            case nameof(Hotel):
                building = new Hotel(buildingName, city, stars, rentAmount);
                break;
            case nameof(Residence):
                building = new Residence(buildingName, city, stars, rentAmount);
                break;
            case nameof(Business):
                building = new Business(buildingName, city, stars, rentAmount);
                break;
        }
        companies[companyName].AddBuilding(building);
        return $"Building {buildingName} was successfully registerd in {companyName} catalog!";
    }
    public string RegisterBroker(List<string> args)
    {
        string brokerName = args[1];
        int age = int.Parse(args[2]);
        string city = args[3];
        string companyName = args[4];
        if (!companies.ContainsKey(companyName))
        {
            return $"Invalid Company: {companyName}. Cannot find it in system!";
        }
        else if (companies[companyName].GetBrokerByName(brokerName) != null)
        {
            return $"Broker {brokerName} is already part of {companyName}!";
        }
        Broker broker = new Broker(brokerName, age, city);
        companies[companyName].AddBroker(broker);
        return $"Broker {brokerName} was successfully hired in {companyName}!";
    }
    public string RentBuilding(List<string> args)
    {
        string companyName = args[1];
        string buildingName = args[2];
        string brokerName = args[3];
        if (!companies.ContainsKey(companyName))
        {
            return $"Invalid Company: {companyName}. Cannot find it in system!";
        }
        Building building = companies[companyName].GetBuildingByName(buildingName);
        Broker broker = companies[companyName].GetBrokerByName(brokerName);
        if (broker == null)
        {
            return $"Invalid Broker: {brokerName}. Cannot find employee in {companyName}!";
        }
        else if (building == null)
        {
            return $"Invalid Building: {buildingName}. Cannot find it in {companyName} catalog!";
        }
        else if (!building.IsAvailable)
        {
            return $"Building: {buildingName} cannot be rented!";
        }
        double bonus = broker.ReceiveBonus(building);
        return $"Successfully rented {buildingName}!\nBroker {brokerName} earned {bonus}!";
    }
    public string CompanyInfo(List<string> args)
    {
        string companyName = args[1];
        if (!companies.ContainsKey(companyName))
        {
            return $"Invalid Company: {companyName}. Cannot find it in system!";
        }
        return companies[companyName].ToString();
    }
    
    public string Shutdown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Companies: {companies.Count}");
        foreach (var c in companies)
        {
            sb.AppendLine(c.Value.ToString());
        }
        return sb.ToString().TrimEnd();
    }
}

