using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        CompanyController controller = new CompanyController();

        try
        {
            while (true)
            {
                List<string> line = Console.ReadLine().Split('*').ToList();
                string cmd = line[0];

                if (cmd == "Shutdown")
                {
                    Console.WriteLine(controller.Shutdown());
                    break;
                }
                switch (cmd)
                {
                    case "CreateCompany":
                        Console.WriteLine(controller.CreateCompany(line));
                        break;
                    case "RegisterBuilding":
                        Console.WriteLine(controller.RegisterBuilding(line));
                        break;
                    case "RegisterBroker":
                        Console.WriteLine(controller.RegisterBroker(line));
                        break;
                    case "RentBuilding":
                        Console.WriteLine(controller.RentBuilding(line));
                        break;
                    case "CompanyInfo":
                        Console.WriteLine(controller.CompanyInfo(line));
                        break;
                }
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }

    }
}