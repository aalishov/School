using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    private Controller controller = new Controller();

    public string Run()
    {
        StringBuilder sb = new StringBuilder();
        string cmd = string.Empty;

        while ((cmd = Console.ReadLine()) != "End")
        {
            string message = string.Empty;
            List<string> args = cmd.Split(' ').Skip(1).ToList();
            cmd = cmd.Split(' ').First();
            try
            {
                switch (cmd)
                {
                    case "Village":
                        message = controller.ProcessVillageCommand(args);
                        break;
                    case "Settle":
                        message = controller.ProcessSettleCommand(args);
                        break;
                    case "Rebel":
                        message = controller.ProcessRebelCommand(args);
                        break;
                    case "Day":
                        message = controller.ProcessDayCommand(args);
                        break;
                    case "Attack":
                        message = controller.ProcessAttackCommand(args);
                        break;
                    case "Info":
                        message = controller.ProcessInfoCommand(args);
                        break;
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            sb.AppendLine(message);
        }
        sb.AppendLine(controller.ProcessEndCommand());
        return sb.ToString().TrimEnd();
    }
}

