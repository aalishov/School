namespace P05_CarManufacturer
{
    public class Tire
    {
        private int year;
        private double pressure;

        public Tire(double pressure, int year)
        {
            this.Pressure = pressure;
            this.Year = year;
        }

        public double Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

    }
}
