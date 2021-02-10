﻿namespace Ex01_FightingArena
{
    public class Weapon
    {
        public Weapon(int size, int solidity, int sharpness)
        {
            this.Size = size;
            this.Solidity = solidity;
            this.Sharpness = sharpness;
        }

        public int Size { get; set; }
        public int Solidity { get; set; }
        public int Sharpness { get; set; }

        public int WeaponSum()
        {
            return this.Size + this.Solidity + this.Sharpness;
        }
    }
}
