using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pharmacy.Web
{
    public class Pharmacy
    {
        private string name;
        private readonly List<Medicine> medicines;
        public Pharmacy(string name)
        {
            this.Name = name;
            this.medicines = new List<Medicine>();
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid name");
                }
                this.name = value;
            }
        }
        public void Order(Medicine medicine)
        {
            this.medicines.Add(medicine);
        }
        public bool Sell(Medicine medicine)
        {
            return this.medicines.Remove(medicine);
        }
        public double CalculateTotalPrice()
        {
            return this.medicines.Sum(x => x.Price);
        }
        public void RenamePharmacy(string newName)
        {
            this.Name = newName;
        }
        public void SellAllMedicines()
        {
            this.medicines.Clear();
        }
        public Medicine GetMedicineWithHighestPrice()
        {
            return this.medicines.OrderBy(x => x.Price).LastOrDefault();
        }
        public Medicine GetMedicineWithLowestPrice()
        {
            return this.medicines.OrderBy(x => x.Price).FirstOrDefault();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pharmacy {this.Name} has {this.medicines.Count} medicines and they are:");
            if (medicines.Any())
            {
                foreach (var m in this.medicines)
                {
                    sb.AppendLine(m.ToString());
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
