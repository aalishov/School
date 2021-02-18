
namespace BrokerCompany.Services
{
    using BrokerCompany.Common;
    using BrokerCompany.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class CompanyController
    {
        private readonly ICollection<ICompany> companies;

        public CompanyController()
        {
            this.companies = new List<ICompany>();
        }
        public string CreateCompany(List<string> args)
        {
            string companyName = args[0];
            ICompany company = this.companies.FirstOrDefault(x => x.Name == companyName);
            if (company == null)
            {
                this.companies.Add(new Company(companyName));
                return string.Format(CompanyControllerSM.CompanyCreateSuccessfully, companyName);
            }
            else
            {
                return string.Format(CompanyControllerSM.CompanyAlreadyRegistered, companyName);
            }
        }

        public string RegisterBuilding(List<string> args)
        {
            string type = args[0];
            string buildingName = args[1];
            string city = args[2];
            int stars = int.Parse(args[3]);
            double rentAmount = double.Parse(args[4]);
            string companyName = args[5];

            ICompany company = this.companies.FirstOrDefault(x => x.Name == companyName);

            if (company == null)
            {
                return string.Format(CompanyControllerSM.CompanyNotFound, companyName);
            }

            IBuilding building = company.GetBuildingByName(buildingName);

            if (building != null)
            {
                return string.Format(CompanyControllerSM.BuildingAlreadyRegistered, buildingName, companyName);
            }

            if (type == "Business")
            {
                building = new Business(buildingName, city, stars, rentAmount);
            }
            else if (type == "Hotel")
            {
                building = new Hotel(buildingName, city, stars, rentAmount);
            }
            else if (type == "Residence")
            {
                building = new Residence(buildingName, city, stars, rentAmount);
            }

            company.AddBuilding(building);

            return string.Format(CompanyControllerSM.BuildingRegisterSuccessfully, buildingName, companyName);
        }

        public string RegisterBroker(List<string> args)
        {
            string brokerName = args[0];
            int age = int.Parse(args[1]);
            string city = args[2];
            string companyName = args[3];

            ICompany company = this.companies.FirstOrDefault(x => x.Name == companyName);

            if (company == null)
            {
                return string.Format(CompanyControllerSM.CompanyNotFound, companyName);
            }

            IBroker broker = company.GetBrokerByName(brokerName);

            if (broker != null)
            {
                return string.Format(CompanyControllerSM.BrokerAlreadyRegistered, brokerName, companyName);
            }

            broker = new Broker(brokerName, age, city);
            company.AddBroker(broker);
            return string.Format(CompanyControllerSM.BrokerRegisterSuccessfully, brokerName, companyName);
        }

        public string RentBuilding(List<string> args)
        {
            string companyName = args[0];
            string buildingName = args[1];
            string brokerName = args[2];

            ICompany company = this.companies.FirstOrDefault(x => x.Name == companyName);
            if (company == null)
            {
                return string.Format(CompanyControllerSM.CompanyNotFound, companyName);
            }

            IBuilding building = company.GetBuildingByName(buildingName);
            if (building == null)
            {
                return string.Format(CompanyControllerSM.BuildingNotFound, buildingName, companyName);
            }
            if (!building.IsAvailable)
            {
                return string.Format(CompanyControllerSM.BuildingAlreadeRented, buildingName);
            }
            IBroker broker = company.GetBrokerByName(brokerName);
            if (broker == null)
            {
                return string.Format(CompanyControllerSM.BrokerNotFound, brokerName, companyName);
            }
            double bonus = broker.ReceiveBonus(building);
            return string.Format(CompanyControllerSM.RentBuildingSuccessfully, buildingName, brokerName, bonus);
        }

        public string CompanyInfo(List<string> args)
        {
            string companyName = args[0];
            ICompany company = this.companies.FirstOrDefault(x => x.Name == companyName);
            if (company==null)
            {
                return string.Format(CompanyControllerSM.CompanyNotFound, companyName);
            }
            return company.ToString();
        }
        public List<string> CompanyList()
        {
            return this.companies.Select(x => x.Name).ToList();
        }

        public string Shutdown()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format(CompanyControllerSM.CompanyCount, this.companies.Count));
            foreach (var company in companies)
            {
                sb.AppendLine(company.ToString());
            }
            return sb.ToString().TrimEnd();
        }

    }
}
