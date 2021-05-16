using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_Pharmacy
{
    class Program
    {
        static Dictionary<string, Medicine> medicines = new Dictionary<string, Medicine>();
        static Dictionary<string, Pharmacy> pharmacies = new Dictionary<string, Pharmacy>();

        static void Main(string[] args)
        {
            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var commandArgs = command.Split(' ').ToArray();

                switch (commandArgs[0])
                {
                    case "AddMedicine":
                        AddMedicine(commandArgs.Skip(1).ToArray());
                        break;
                    case "CreatePharmacy":
                        CreatePharmacy(commandArgs.Skip(1).ToArray());
                        break;
                    case "Order":
                        Order(commandArgs.Skip(1).ToArray());
                        break;
                    case "Sell":
                        Sell(commandArgs.Skip(1).ToArray());
                        break;
                    case "CalculateTotalPrice":
                        CalculateTotalPrice(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetMedicineWithHighestPrice":
                        GetMedicineWithHighestPrice(commandArgs.Skip(1).ToArray());
                        break;
                    case "GetMedicineWithLowestPrice":
                        GetMedicineWithLowestPrice(commandArgs.Skip(1).ToArray());
                        break;
                    case "RenamePharmacy":
                        RenamePharmacy(commandArgs.Skip(1).ToArray());
                        break;
                    case "SellAllMedicines":
                        SellAllMedicines(commandArgs.Skip(1).ToArray());
                        break;
                    case "MedicineInfo":
                        MedicineInfo(commandArgs.Skip(1).ToArray());
                        break;
                    case "PharmacyInfo":
                        PharmacyInfo(commandArgs.Skip(1).ToArray());
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }
            }

        }

        private static void PharmacyInfo(string[] v)
        {
            string pharmacyName = v[0];

            if (!pharmacies.ContainsKey(pharmacyName))
            {
                Console.WriteLine("Could not get PharmacyInfo");
                return;
            }
            Pharmacy pharmacy = pharmacies[pharmacyName];
            Console.WriteLine(pharmacy);
        }

        private static void MedicineInfo(string[] v)
        {
            string medicineName = v[0];

            if (!medicines.ContainsKey(medicineName))
            {
                Console.WriteLine("Could not get MedicineInfo");
                return;
            }
            Medicine medicine = medicines[medicineName];
            Console.WriteLine(medicine);
        }

        private static void SellAllMedicines(string[] v)
        {
            string pharmacyName = v[0];

            if (!pharmacies.ContainsKey(pharmacyName))
            {
                Console.WriteLine("Could not SellAllMedicines");
                return;
            }
            Pharmacy pharmacy = pharmacies[pharmacyName];

            pharmacy.SellAllMedicines();
        }

        private static void RenamePharmacy(string[] v)
        {
            string pharmacyName = v[0];
            string newName = v[1];

            if (!pharmacies.ContainsKey(pharmacyName))
            {
                Console.WriteLine("Could not RenamePharmacy");
                return;
            }
            Pharmacy pharmacy = pharmacies[pharmacyName];

            try
            {
                pharmacy.RenamePharmacy(newName);
                pharmacies.Remove(pharmacyName);
                pharmacies.Add(newName, pharmacy);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void GetMedicineWithLowestPrice(string[] v)
        {
            string pharmacyName = v[0];


            if (!pharmacies.ContainsKey(pharmacyName))
            {
                Console.WriteLine("Could not GetEmployeeWithLowestPrice");
                return;
            }
            Pharmacy pharmacy = pharmacies[pharmacyName];

            Console.WriteLine(pharmacy.GetMedicineWithLowestPrice());
        }

        private static void GetMedicineWithHighestPrice(string[] v)
        {
            string pharmacyName = v[0];

            if (!pharmacies.ContainsKey(pharmacyName))
            {
                Console.WriteLine("Could not GetMedicineWithHighestPrice");
                return;
            }
            Pharmacy pharmacy = pharmacies[pharmacyName];

            Console.WriteLine(pharmacy.GetMedicineWithHighestPrice());
        }

        private static void CalculateTotalPrice(string[] v)
        {
            string pharmacyName = v[0];

            if (!pharmacies.ContainsKey(pharmacyName))
            {
                Console.WriteLine("Could not CalculateTotalPrice");
                return;
            }
            Pharmacy pharmacy = pharmacies[pharmacyName];

            Console.WriteLine(pharmacy.CalculateTotalPrice());
        }

        private static void Sell(string[] v)
        {
            string medicineName = v[0];
            string pharmacyName = v[1];

            if (!pharmacies.ContainsKey(pharmacyName) || !medicines.ContainsKey(medicineName))
            {
                Console.WriteLine("Could not sell medicine");
                return;
            }

            Medicine medicine = medicines[medicineName];
            Pharmacy pharmacy = pharmacies[pharmacyName];
            if (pharmacy.Sell(medicine))
            {
                Console.WriteLine($"Sold medicine {medicineName}");
            }
            else
            {
                Console.WriteLine($"Did not sell medicine {medicineName}");
            }
        }

        private static void Order(string[] v)
        {
            string medicineName = v[0];
            string pharmacyName = v[1];

            if (!pharmacies.ContainsKey(pharmacyName) || !medicines.ContainsKey(medicineName))
            {
                Console.WriteLine("Could not order medicine");
                return;
            }
            Medicine medicine = medicines[medicineName];
            Pharmacy pharmacy = pharmacies[pharmacyName];
            pharmacy.Order(medicine);
        }

        private static void CreatePharmacy(string[] v)
        {
            string name = v[0];

            try
            {
                Pharmacy pharmacy = new Pharmacy(name);
                pharmacies.Add(name, pharmacy);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private static void AddMedicine(string[] v)
        {
            string name = v[0];
            double price = double.Parse(v[1]);

            try
            {
                Medicine medicine = new Medicine(name, price);
                medicines.Add(name, medicine);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}