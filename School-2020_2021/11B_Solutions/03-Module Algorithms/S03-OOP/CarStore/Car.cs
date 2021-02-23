namespace CarStore
{
    public class Car
    {
        private int number;
        private double price;

        public Car()
        {

        }
        public Car(int number)
        {
            Number = number;
        }

        public Car(int number, double price)
        {
            Number = number;
            Price = price;
        }

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
            }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return $"Number: {this. number} => {this.Price}";
        }
    }
}
