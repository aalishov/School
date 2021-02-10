namespace CounterStrike.Models.Players
{
    using CounterStrike.Models.Guns.Contracts;
    using CounterStrike.Models.Players.Contracts;
    using CounterStrike.Utilities.Messages;
    using System;
    using System.Text;

    public abstract class Player : IPlayer
    {
        private string username;
        private int health;
        private int armor;
        private IGun gun;

        protected Player(string username, int health, int armor, IGun gun)
        {
            this.Username = username;
            this.Health = health;
            this.Armor = armor;
            this.Gun = gun;
            this.IsAlive = true;
        }

        public string Username
        {
            get { return username; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerName);
                }
                username = value;
            }
        }

        public int Health
        {
            get { return health; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerHealth);
                }
                health = value;
            }
        }

        public int Armor
        {
            get { return armor; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerArmor);
                }
                armor = value;
            }
        }

        public IGun Gun
        {
            get { return gun; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGun);
                }
                gun = value;
            }
        }

        public bool IsAlive { get; private set; }

        //TODO: Check Player method - TakeDamage
        public void TakeDamage(int points)
        {
            if (this.Armor >= points)
            {
                this.Armor -= points;
            }
            else if (this.Armor == 0)
            {
                TakeHealthDamage(points);
            }
            else
            {
                points -= Armor;
                this.Armor = 0;
                TakeHealthDamage(points);
            }
        }

        private void TakeHealthDamage(int points)
        {
            if (this.Health > points)
            {
                this.Health -= points;
            }
            else
            {
                this.IsAlive = false;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}: {this.Username}");
            sb.AppendLine($"--Health: {this.Health}");
            sb.AppendLine($"--Armor: {this.Armor}");
            sb.AppendLine($"--Gun: {this.Gun.Name}");

            return sb.ToString().TrimEnd();
        }
    }
}
