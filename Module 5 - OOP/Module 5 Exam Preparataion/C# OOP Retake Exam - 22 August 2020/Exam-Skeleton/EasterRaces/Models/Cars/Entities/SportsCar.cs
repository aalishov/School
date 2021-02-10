namespace EasterRaces.Models.Cars.Entities
{
    public class SportsCar : Car
    {
        private const int SportsCarCubicCentimeters = 3000;
        private const int SportsCarMinHorsePower = 250;
        private const int SportsCarMaxHorsePower = 450;
        public SportsCar(string model, int horsePower) : base(model, horsePower, SportsCarCubicCentimeters, SportsCarMinHorsePower, SportsCarMaxHorsePower)
        {
        }
    }
}
