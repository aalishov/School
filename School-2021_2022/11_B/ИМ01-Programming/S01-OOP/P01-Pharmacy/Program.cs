using System;

namespace P01_Pharmacy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pharmacy pharmacy = new Pharmacy("Pharmacy 1");
            Medicine m1 = new Medicine("Analgin", 2.2);
            Medicine m2 = new Medicine("Paracetamol", 1.8);
            Medicine m3 = new Medicine("Antibiotik", 5.5);

            pharmacy.Order(m1);
            pharmacy.Order(m2);
            pharmacy.Order(m3);

            //pharmacy.Sell(m2);

            pharmacy.RenamePharmacy("Pharmacy 5");

            //pharmacy.SellAllMedicines();
            Console.WriteLine(pharmacy.CalculateTotalPrice());
            //Console.WriteLine(pharmacy.Name);
            Console.WriteLine(pharmacy.GetMedicineWithHighestPrice());
            Console.WriteLine(pharmacy.GetMedicineWithLowestPrice());
        }
    }
}
