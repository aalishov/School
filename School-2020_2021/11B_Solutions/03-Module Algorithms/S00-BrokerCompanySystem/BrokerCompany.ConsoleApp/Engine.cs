

namespace BrokerCompany.ConsoleApp
{
    using BrokerCompany.Services;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private readonly CompanyController companyController;

        public Engine(CompanyController companyController)
        {
            this.companyController = companyController;
        }

        public void Run()
        {
            bool isRun = true;
            try
            {
                while (isRun)
                {
                    List<string> args = Console.ReadLine()
                        .Split('*')
                        .ToList();
                    string cmd = args[0];

                    string result = string.Empty;
                    args.RemoveAt(0);
                    switch (cmd)
                    {
                        case "CreateCompany":
                            result = companyController.CreateCompany(args);
                            break;
                        case "RegisterBuilding":
                            result = companyController.RegisterBuilding(args);
                            break;
                        case "RegisterBroker":
                            result = companyController.RegisterBroker(args);
                            break;
                        case "RentBuilding":
                            result = companyController.RentBuilding(args);
                            break;
                        case "CompanyInfo":
                            result = companyController.CompanyInfo(args);
                            break;
                        case "Shutdown":
                            isRun = false;
                            result = companyController.Shutdown();
                            break;
                    }
                    Console.WriteLine(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
