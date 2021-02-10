namespace P01_StoreSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        private StoreController controller;

        public Engine()
        {
            this.controller = new StoreController();
        }

        public void Run()
        {
            bool isRun = true;

            while (isRun)
            {
                try
                {
                    List<string> input = Console.ReadLine().Split(':').ToList();
                    string cmd = input[0];

                    List<string> args = input.Skip(1).ToList();

                    string result = string.Empty;
                    switch (cmd)
                    {
                        case "CreateStore":
                            result = this.controller.CreateStore(args);
                            break;
                        case "ReceiveProduct":
                            result = this.controller.ReceiveProduct(args);
                            break;
                        case "SellProduct":
                            result = this.controller.SellProduct(args);
                            break;
                        case "StoreInfo":
                            result = this.controller.StoreInfo(args);
                            break;
                        case "Shutdown":
                            isRun = false;
                            result = this.controller.Shutdown();
                            break;
                    }

                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
