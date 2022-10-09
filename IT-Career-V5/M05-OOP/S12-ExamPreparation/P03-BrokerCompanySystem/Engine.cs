using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    private CompanyController controller;

    public Engine()
    {
        controller = new CompanyController();
        this.Run();
    }

    public void Run()
    {
        StringBuilder sb = new StringBuilder();
        while (true)
        {
            List<string> args = Console.ReadLine().Split('*').ToList();
            string cmd=args[0];
            try
            {
                switch (cmd)
                {
                    case "CreateCompany":
                        sb.AppendLine(controller.CreateCompany(args));
                        break;
                    case "RegisterBuilding":
                        sb.AppendLine(controller.RegisterBuilding(args));
                        break;
                    case "RegisterBroker":
                        sb.AppendLine(controller.RegisterBroker(args));
                        break;
                    case "RentBuilding":
                        sb.AppendLine(controller.RentBuilding(args));
                        break;
                    case "CompanyInfo":
                        sb.AppendLine(controller.CompanyInfo(args));
                        break;
                    case "Shutdown":
                        sb.AppendLine(controller.Shutdown());
                        Console.Clear();
                        Console.WriteLine(sb.ToString().TrimEnd());
                        Environment.Exit(0);
                        break;
                }
            }
            catch (Exception ex)
            {
                sb.AppendLine(ex.Message);
            }
        }
    }
}

