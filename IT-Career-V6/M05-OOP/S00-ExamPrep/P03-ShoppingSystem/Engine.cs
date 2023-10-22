namespace ShoppingSystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class Engine
    {
        Controller c = new Controller();
        public Engine()
        {
            Run();
        }

        public void Run()
        {
            StringBuilder sb= new StringBuilder();
            while (true)
            {
                string result = string.Empty;
                try
                {
                    List<string> input = Console.ReadLine()
                    .Split(" ")
                    .ToList();
                    string cmd = input[0];
                    List<string> args = input.Skip(1).ToList();

                    switch (cmd)
                    {
                        case "Product":
                            result = c.ProcessProductCommand(args);
                            break;
                        case "Service":
                            result = c.ProcessServiceCommand(args);
                            break;
                        case "Checkout":
                            result = c.ProcessCheckoutCommand(args);
                            break;
                        case "Info":
                            result = c.ProcessInfoCommand(args);
                            break;
                        case "End":
                            result = c.ProcessEndCommand();
                            Console.WriteLine(result);
                            sb.AppendLine(result);
                            File.WriteAllText("C:\\Users\\aalis\\Desktop\\result.txt", sb.ToString().TrimEnd());
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                    sb.AppendLine(result);
                }
               
                Console.WriteLine(result);
                sb.AppendLine(result);
            }
            
        }
    }
}

