public class Player
{
    private string name;
    private int endurance;
    private int sprinting;
    private int dribbling;
    private int passing;
    private int shooting;

    public Player(string name, int endurance, int sprinting, int dribbling, int passing, int shooting)
    {
        Name = name;
        Endurance = endurance;
        Sprinting = sprinting;
        Dribbling = dribbling;
        Passing = passing;
        Shooting = shooting;
    }

    public string Name
    {
        get => name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            name = value;
        }
    }

    public int Endurance
    {
        get => endurance;
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Endurance should be between 0 and 100.");
            }
            endurance = value;
        }
    }

    public int Sprinting
    {
        get => sprinting;
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Sprinting should be between 0 and 100.");
            }
            sprinting = value;
        }
    }

    public int Dribbling
    {
        get => dribbling;
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Dribbling should be between 0 and 100.");
            }
            dribbling = value;
        }
    }

    public int Passing
    {
        get => passing;
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Passing should be between 0 and 100.");
            }
            passing = value;
        }
    }

    public int Shooting
    {
        get => shooting;
        private set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException("Shooting should be between 0 and 100.");
            }
            shooting = value;
        }
    }

    public double Rating
    {
        get
        {
            return Math.Round((Endurance + Sprinting + Dribbling + Passing + Shooting) / 5.0, 2);
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}, rating: {Rating:f2}";
    }
}

