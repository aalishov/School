using System;

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

    public int GetTotalPower()
    {
        return GetWeaponPower() + GetStatPower();
    }

    public int GetWeaponPower()
    {
        return Weapon.Sharpnes + Weapon.Size + Weapon.Solidity;
    }

    public int GetStatPower()
    {
        return Stat.Agility + Stat.Flexibility +
            Stat.Intelligence + Stat.Skills +
            Stat.Strength;
    }

    public override string ToString()
    {
        return $"{this.Name} - {GetTotalPower()}{Environment.NewLine}  Weapon Power: {GetWeaponPower()}{Environment.NewLine}  Stat Power: {GetTotalPower()}";
    }
}

