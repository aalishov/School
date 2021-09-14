namespace SpaceStation.Models.Astronauts
{
    public class Biologist : Astronaut
    {
        private const double InitialOxygen = 70;
        private const double DecreaseOxygen = 5;
        public Biologist(string name) : base(name, InitialOxygen)
        {
        }

        public override void Breath()
        {
            this.Oxygen -= DecreaseOxygen;
        }
    }
}
