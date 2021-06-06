public class Weapon
{
    public Weapon(int size, int solidity, int sharpness)
    {
        this.Size = size;
        this.Solidity = solidity;
        this.Sharpnes = sharpness;
    }

    public int Size { get; set; }

    public int Solidity { get; set; }

    public int Sharpnes { get; set; }
}
