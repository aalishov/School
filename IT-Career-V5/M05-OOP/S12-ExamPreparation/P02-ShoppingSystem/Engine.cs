using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Engine
{
    private Controller controller;
    public Engine()
    {
        controller = new Controller();
        this.Run();
    }
    public void Run()
    {
        StringBuilder sb = new StringBuilder();
        string message = string.Empty;
        
        while (true)
        {
            List<string> args = Console.ReadLine()
                .Split(' ')
                .ToList();
            try
            {
                switch (args[0])
                {
                    case "Product":
                        message = controller.ProcessProductCommand(args);
                        break;
                    case "Service":
                        message = controller.ProcessServiceCommand(args);
                        break;
                    case "Checkout":
                        message = controller.ProcessCheckoutCommand(args);
                        break;
                    case "Info":
                        message = controller.ProcessInfoCommand(args);
                        break;
                    case "End":
                        message = controller.ProcessEndCommand();
                        Console.WriteLine(message);
                        sb.AppendLine(message);
                        File.WriteAllText("output.txt",sb.ToString());
                        Environment.Exit(0);
                        break;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            Console.WriteLine(message);
            sb.AppendLine(message);
        }
    }
}

