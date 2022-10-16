using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    StoreController controller;
    public Engine()
    {
        this.controller = new StoreController();
        this.Run();
    }
    public void Run()
    {
        while (true)
        {
            List<string> args = Console.ReadLine().Split(':').ToList();
            string result=string.Empty;
            try
            {
                switch (args[0])
                {
                    case "CreateStore":
                        result = controller.CreateStore(args);
                        break;
                    case "ReceiveProduct":
                        result = controller.ReceiveProduct(args);
                        break;
                    case "SellProduct":
                        result = controller.SellProduct(args);
                        break;
                    case "StoreInfo":
                        result = controller.StoreInfo(args);
                        break;
                    case "Shutdown":
                        result = controller.Shutdown();
                        Console.WriteLine(result);
                        Environment.Exit(0);
                        break;
                }
            }
            catch (Exception ex)
            {
                result= ex.Message;
            }
            Console.WriteLine(result);
        }
    }
}

