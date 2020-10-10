namespace StorageMaster
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    public class Engine
    {
        private StorageMaster storageMaster = new StorageMaster();


        public void Run()
        {
            while (true)
            {
                string[] readLine = Console.ReadLine().Split(' ');

                string cmd = readLine[0];

                if (cmd == "END")
                {
                    Console.WriteLine(storageMaster.GetSummary());
                    break;
                }
                try
                {
                    switch (cmd)
                    {
                        case "AddProduct":
                            AddProduct(readLine);
                            break;
                        case "RegisterStorage":
                            RegisterStorage(readLine);
                            break;
                        case "SelectVehicle":
                            SelectVehicle(readLine);
                            break;
                        case "LoadVehicle":
                            LoadVehicle(readLine);
                            break;
                        case "SendVehicleTo":
                            SendVehicleTo(readLine);
                            break;
                        case "UnloadVehicle":
                            UnloadVehicle(readLine);
                            break;
                        case "GetStorageStatus":
                            GetStorageStatus(readLine);
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Error:"+ex.Message);
                }
               
            }
        }

        private void GetStorageStatus(string[] readLine)
        {
            string storageName = readLine[1];
            Console.WriteLine(storageMaster.GetStorageStatus(storageName));
        }

        private void UnloadVehicle(string[] readLine)
        {
            string storageName = readLine[1];
            int garageSlot = int.Parse(readLine[2]);
            Console.WriteLine(storageMaster.UnloadVehicle(storageName, garageSlot));
        }

        private void SendVehicleTo(string[] readLine)
        {
            string sourceName = readLine[1];
            int garageSlot = int.Parse(readLine[2]);
            string destinationName = readLine[3];
            Console.WriteLine(storageMaster.SendVehicleTo(sourceName, garageSlot, destinationName));
        }

        private void LoadVehicle(string[] readLine)
        {
            IEnumerable<string> products = readLine.Skip(1).ToList();
            Console.WriteLine(storageMaster.LoadVehicle(products));
        }

        private void SelectVehicle(string[] readLine)
        {
            string storageName = readLine[1];
            int garageSlot = int.Parse(readLine[2]);
            Console.WriteLine(storageMaster.SelectVehicle(storageName, garageSlot));
        }

        private void RegisterStorage(string[] readLine)
        {
            string type = readLine[1];
            string name = readLine[2];
            Console.WriteLine(storageMaster.RegisterStorage(type, name));
        }

        private void AddProduct(string[] readLine)
        {
            string type = readLine[1];
            double price = double.Parse(readLine[2]);
            Console.WriteLine(storageMaster.AddProduct(type, price));
        }
    }
}
