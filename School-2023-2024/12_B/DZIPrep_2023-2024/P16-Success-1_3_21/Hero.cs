using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Hero
{
    private int health;

    public Hero(int x, int y, int power, int health)
    {
        this.X = x;
        this.Y = y;
        this.Power = power;
        this.Health = health;
    }

    public int X { get; private set; }
    public int Y { get; private set; }
    public int Power { get; private set; }
    public int Health
    {
        get { return health; }
        private set
        {
            if (value<=0)
            {
                throw new ArgumentException("He already died");
            }
            health = value;
        }
    }
    private double Manhattan(double mushroomX, double mushroomY)
    {
        return Math.Abs(this.X - mushroomX) + Math.Abs(this.Y - mushroomY);
    }
    public void Eat(Mushroom mushroom)
    {
        if (Manhattan(mushroom.X,mushroom.Y)<=this.Power)
        {
            this.Health += mushroom.Condition;
        }
    }
    public override string ToString()
    {
        return $"Hero has health {this.Health} after they ate a mushroom";
    }
}
