using System;
using System.Linq;

namespace Village
{
    public class Engine
    {
        public void Run()
        {
            Controller controller = new Controller();
            string command = "";
            do
            {
                try
                {
                    command = Console.ReadLine();
                    string[] commandData = command.Split(' ').ToArray();

                    switch (commandData[0])
                    {
                        case "Village":
                            Console.WriteLine(controller.ProcessVillageCommand(commandData.Skip(1).ToList()));
                            break;
                        case "Settle":
                            Console.WriteLine(controller.ProcessSettleCommand(commandData.Skip(1).ToList()));
                            break;
                        case "Rebel":
                            Console.WriteLine(controller.ProcessRebelCommand(commandData.Skip(1).ToList()));
                            break;
                        case "Day":
                            Console.WriteLine(controller.ProcessDayCommand(commandData.Skip(1).ToList()));
                            break;
                        case "Attack":
                            Console.WriteLine(controller.ProcessAttackCommand(commandData.Skip(1).ToList()));
                            break;
                        case "Info":
                            Console.WriteLine(controller.ProcessInfoCommand(commandData.Skip(1).ToList()));
                            break;
                        case "End":
                            Console.WriteLine(controller.ProcessEndCommand());
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            } while (command != "End");

        }
    }

}