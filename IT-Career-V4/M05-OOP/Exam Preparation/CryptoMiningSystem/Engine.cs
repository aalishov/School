using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CryptoMiningSystem
{
    public class Engine
    {
        private PCController controller = new PCController();

        public void Run()
        {
            string path = @"D:\GIT\School\IT-Career-V4\M05-OOP\Exam Preparation\CryptoMiningSystem\output.txt";
            StreamWriter writer = new StreamWriter(path, false);
            using (writer)
            {

                while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split(", ")
                    .ToList();
                string cmd = input[0];
                string result = string.Empty;


                try
                {
                    if (cmd == "Shutdown")
                    {
                            result = controller.Shutdown();
                            Console.WriteLine(result);
                            writer.WriteLine(result);
                        break;
                    }
                    List<string> args = input.Skip(1).ToList();
                    switch (cmd)
                    {
                        case "RegisterUser":
                            result = controller.RegisterUser(args);
                            break;
                        case "CreateComputer":
                            result = controller.CreateComputer(args);
                            break;
                        case "Mine":
                            result = controller.Mine();
                            break;
                        case "UserInfo":
                            result = controller.UserInfo(args);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    result = ex.Message;
                }
                Console.WriteLine(result);

                
                    writer.WriteLine(result);
                }
            }
        }
    }
}
