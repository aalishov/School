using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex07_Pharmacy
{
    public class Pharmacy
    {
        private readonly List<Medicine> medicines;
        private string name;

        public Pharmacy(string name)
        {
            this.Name = name;
            this.medicines = new List<Medicine>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length<3)
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value;
            }
        }

        public void Order(Medicine medicine)
        {
            this.medicines.Add(medicine);
        }

        public bool Sell(Medicine medicine)
        {
            // ! Search by name
            return medicines.Remove(medicine);
        }

        public double CalculateTotalPrice()
        {
            return medicines.Sum(x => x.Price);
        }

        public Medicine GetMedicineWithHighestPrice()
        {
            return medicines.OrderByDescending(x => x.Price).First();
        }

        public Medicine GetMedicineWithLowestPrice()
        {
            return medicines.OrderByDescending(x => x.Price).Last();
        }

        public void RenamePharmacy(string newName)
        {
            this.Name = newName;
        }

        public void SellAllMedicines()
        {
            medicines.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pharmacy {this.Name} has {medicines.Count} medicines and they are:");
            if (medicines.Any())
            {
                foreach (var medicine in medicines)
                {
                    sb.AppendLine(medicine.ToString());
                }
            }
            else
            {
                sb.AppendLine("N/A");
            }
            return sb.ToString().TrimEnd();
        }

    }
}
