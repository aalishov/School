using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryptoMiningSystem
{
    public class Engine
    {
        private PCController controller = new PCController();

        public void Run()
        {
            while (true)
            {
                List<string> input = Console.ReadLine()
                    .Split(' ')
                    .ToList();
                string cmd = input[0];
                if (cmd=="Shutdown")
                {
                    Console.WriteLine(controller.Shutdown());
                    break;
                }
                List<string> args = input.Skip(1).ToList();

                switch (cmd)
                {
                    case "RegisterUser":
                        Console.WriteLine(controller.RegisterUser(args));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
