using Headhunt.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headhunt.Core
{
    class Engine : IEngine
    {
        public void Run()
        {
            JobController controller = new JobController();
            string command = "";
            do
            {
                try
                {
                    command = Console.ReadLine();
                    string[] commandData = command.Split('|').ToArray();

                    switch (commandData[0])
                    {
                        case "CreatePosition":
                            Console.WriteLine(controller.CreatePosition(commandData.Skip(1).ToList()));
                            break;
                        case "CreateWorker":
                            Console.WriteLine(controller.CreateWorker(commandData.Skip(1).ToList()));
                            break;
                        case "Apply":
                            Console.WriteLine(controller.Apply(commandData.Skip(1).ToList()));
                            break;
                        case "PositionInfo":
                            Console.WriteLine(controller.PositionInfo(commandData.Skip(1).ToList()));
                            break;
                        case "WorkerInfo":
                            Console.WriteLine(controller.WorkerInfo(commandData.Skip(1).ToList()));
                            break;
                        case "ListPositionApplicantsByExperience":
                            Console.WriteLine(controller.ListPositionApplicantsByExperience(commandData.Skip(1).ToList()));
                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(  ex.Message);
                }
               

            } while (command != "End");

        }
    }
}
