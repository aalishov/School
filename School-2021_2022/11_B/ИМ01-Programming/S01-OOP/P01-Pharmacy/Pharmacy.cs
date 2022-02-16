using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Pharmacy
{
    public class Pharmacy
    {
        private readonly ICollection<Medicine> medicines;

        public Pharmacy(string name)
        {
            this.Name = name;
            this.medicines = new List<Medicine>();
        }

        public string Name { get; private set; }

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
    }
}
