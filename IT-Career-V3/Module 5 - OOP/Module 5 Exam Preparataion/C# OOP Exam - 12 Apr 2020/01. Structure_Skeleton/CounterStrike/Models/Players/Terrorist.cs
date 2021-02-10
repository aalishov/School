namespace CounterStrike.Models.Players
{
    using CounterStrike.Models.Guns.Contracts;

    public class Terrorist : Player
    {
        public Terrorist(string username, int health, int armor, IGun gun) : base(username, health, armor, gun)
        {
        }
    }
}
