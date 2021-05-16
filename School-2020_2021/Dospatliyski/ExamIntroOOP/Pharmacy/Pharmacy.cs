namespace Exam_Pharmacy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Pharmacy
    {
        private readonly List<Medicine> medicines;

        private string name;

        public Pharmacy(string name)
        {
            Name = name;
            this.medicines = new List<Medicine>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length < 3)
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
            return this.medicines.Remove(medicine);
        }

        public double CalculateTotalPrice()
        {
            return this.medicines.Sum(x => x.Price);
        }

        public Medicine GetMedicineWithHighestPrice()
        {
            return this.medicines.OrderBy(x => x.Price).LastOrDefault();
        }

        public Medicine GetMedicineWithLowestPrice()
        {
            return this.medicines.OrderBy(x => x.Price).FirstOrDefault();
        }

        public void RenamePharmacy(string newName)
        {
            this.Name = newName;
        }

        public void SellAllMedicines()
        {
            this.medicines.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Pharmacy {this.Name} has {this.medicines.Count} medicines and they are:");
            if (this.medicines.Any())
            {
                foreach (var m in medicines)
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