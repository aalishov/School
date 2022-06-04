using System.Numerics;
public class Program
{
    public static void Main()
    {

        Flower flower = new Flower("");
    }

    class Flower
    {
        private string type;

        public Flower(string type)
        {
            Type = type;
        }

        public string Type
        {
            get { return this.type; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid type!");
                }
                this.type = value;
            }
        }

        public override string ToString()
        {
            return $"Flower<вид> with color<цвят> costs<цена>";
        }
    }
}