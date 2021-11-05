using System;
using System.Linq;

namespace Village
{
    public class Engine
    {
        public void Run()
        {
            Controller controller = new Controller();
            while (true)
            {
                try
                {
                    var input = Console.ReadLine().Split(' ').ToList();
                    var swither = input[0];
                    input.RemoveAt(0);

                    switch (swither)
                    {
                        case "Village":
                            Console.WriteLine(controller.ProcessVillageCommand(input));
                            break;
                        case "Settle":
                            Console.WriteLine(controller.ProcessSettleCommand(input));
                            break;
                        case "Rebel":
                            Console.WriteLine(controller.ProcessRebelCommand(input));
                            break;
                        case "Day":
                            Console.WriteLine(controller.ProcessDayCommand(input));
                            break;
                        case "Attack":
                            Console.WriteLine(controller.ProcessAttackCommand(input));
                            break;
                        case "Info":
                            Console.WriteLine(controller.ProcessInfoCommand(input));
                            break;
                        case "End":
                            Console.WriteLine(controller.ProcessEndCommand());
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }
}