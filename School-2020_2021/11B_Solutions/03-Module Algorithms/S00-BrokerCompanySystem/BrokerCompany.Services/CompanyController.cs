
namespace BrokerCompany.Services
{
    using BrokerCompany.Common;
    using BrokerCompany.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

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

            return string.Format(CompanyControllerSM.BrokerRegisterSuccessfully,buildingName,companyName);
        }

        public string RegisterBroker(List<string> args)
        {
            throw new NotImplementedException();
        }

        public string RentBuilding(List<string> args)
        {
            throw new NotImplementedException();
        }

        public string CompanyInfo(List<string> args)
        {
            throw new NotImplementedException();
        }

        public string Shutdown()
        {
            throw new NotImplementedException();
        }

    }
}
