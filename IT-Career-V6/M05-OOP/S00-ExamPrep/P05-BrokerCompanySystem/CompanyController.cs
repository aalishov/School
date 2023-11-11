using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_BrokerCompanySystem
{
    public class CompanyController
    {
        private Dictionary<string, Company> companies = new();
        public string CreateCompany(List<string> args)
        {
            string name = args[0];
            if (companies.ContainsKey(name))
            {
                return $"Company {name} is already registered!";
            }
            companies.Add(name, new Company(name));
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
            if (!companies.ContainsKey(companyName))
            {
                return $"Invalid Company: {companyName}. Cannot find it in system!";
            }
            else if (companies[companyName].GetBuildingByName(name) != null)
            {
                return $"Building {name} is already registered in {companyName}!";
            }
            Building building = null;
            if (type == "Hotel")
            {
                building = new Hotel(name, city, stars, rentAmount);
            }
            else if (type == "Residence")
            {
                building = new Residence(name, city, stars, rentAmount);
            }
            else if (type == "Business")
            {
                building = new Business(name, city, stars, rentAmount);
            }
            companies[companyName].AddBuilding(building);
            return $"Building {name} was successfully registerd in {companyName} catalog!";
        }
        public string RegisterBroker(List<string> args)
        {
            string name = args[0];
            int age = int.Parse(args[1]);
            string city = args[2];
            string companyName = args[3];
            if (!companies.ContainsKey(companyName))
            {
                return $"Invalid Company: {companyName}. Cannot find it in system!";
            }
            else if (companies[companyName].GetBrokerByName(name) != null)
            {
                return $"Broker {name} is already part of {companyName}!";
            }
            Broker broker = new Broker(name, age, city);
            companies[companyName].AddBroker(broker);
            return $"Broker {name} was successfully hired in {companyName}!";
        }
        public string RentBuilding(List<string> args)
        {
           string companyName = args[0];
           string buildingName = args[1];
           string brokerName = args[2];
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
            return $"Successfully rented {buildingName}! {Environment.NewLine}Broker {brokerName} earned {bonus}!";
        }
        public string CompanyInfo(List<string> args)
        {
            string companyName = args[0];
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
            foreach (var item in companies)
            {
               sb.AppendLine(item.Value.ToString());
                
            }
            return sb.ToString().TrimEnd();
        }
    }
}
