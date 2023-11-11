public class Program
{
    public static void Main(string[] args)
    {
        Product p1 = new Product("Pen", "other");
        Product p2 = new Product("Bread","Food",0.400,0.300,0.150);
    }

    public class MyDateTime
    {
        public int Day { get; set; }

        public int Month { get; set; }
        public int Year { get; set; }
    }

}


public class Dog
{
    private int age;
    public Dog() { }

    public Dog(int age)
    {
        Age = age;
    }

    public Dog(string breed)
    {
        Breed = breed;
    }

    public Dog(string color, string breed)
    {
        Color = color;
        Breed = breed;
    }

    public Dog(string color, string breed, int age)
    {
        Color = color;
        Breed = breed;
        Age = age;
    }

    public string Color { get; set; }
    public string Breed { get; set; }
    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("INVALID!");
            }
            age = value;
        }
    }
}