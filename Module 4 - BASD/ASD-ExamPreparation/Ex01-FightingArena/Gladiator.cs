namespace Ex01_FightingArena
{
    using System.Text;
    public class Gladiator
    {
        public Gladiator(string name, Stat stat, Weapon weapon)
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public string Name { get; set; }
        public Stat Stat { get; set; }
        public Weapon Weapon { get; set; }

        public int GetTotalaPower()
        {
            // return this.Stat.StatSum()+ this.Weapon.WeaponSum();

            return GetWeaponPower() + GetStatPower();
        }

        public int GetWeaponPower()
        {
            return this.Weapon.WeaponSum();
        }

        public int GetStatPower()
        {
            return this.Stat.StatSum();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"[{this.Name}] - [{this.GetTotalaPower()}]");
            sb.AppendLine($"  Weapon Power: [{this.GetWeaponPower()}]");
            sb.AppendLine($"  Stat Power: [{this.GetStatPower()}]");
            return sb.ToString().TrimEnd();
        }
    }
}
