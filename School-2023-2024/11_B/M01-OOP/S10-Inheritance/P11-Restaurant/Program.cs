namespace P11_Restaurant
{
    public class Program
    {
        public void Main(string[] args)
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split(" ").ToArray();
                if (input[0] == "End")
                {
                    break;
                }
                string type = input[0];
                string name = input[1]; 
                decimal price = decimal.Parse(input[2]);
                Product product = null;
                switch (type)
                {
                    case nameof(Coffee):
                        double caffeine = double.Parse(input[3]);

                        break;
                }
            }
        }
    }
}