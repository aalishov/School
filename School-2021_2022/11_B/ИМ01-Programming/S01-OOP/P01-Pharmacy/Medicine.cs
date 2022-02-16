namespace P01_Pharmacy
{
    public class Medicine
    {
        public Medicine(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; private set; }

        public double Price { get; private set; }

        public override string ToString()
        {
            return $"Medicine: {this.Name} with price {this.Price}";
        }
    }
}
