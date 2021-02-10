namespace P04_SnooketTickets
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Stage: ");
            string stage = Console.ReadLine();
            Console.Write("Ticket type: ");
            string ticket = Console.ReadLine();
            Console.Write("Number of tickets: ");
            int numbers = int.Parse(Console.ReadLine());
            Console.Write("Take photo: ");
            char photo = Console.ReadKey().KeyChar;
            Console.WriteLine();

            decimal price = 0.0m;
            price = SelectPrice(stage, ticket, price);

            price *= numbers;



            if (price>4000)
            {                
                price *= 0.75m;

            }
            else if (price>2500)
            {
                price *= 0.9m;
                price = AddPhotoPrice(numbers, photo, price);
            }
            else
            {
                price = AddPhotoPrice(numbers, photo, price);
            }


            Console.WriteLine(Math.Round(price,2));

        }

        private static decimal AddPhotoPrice(int numbers, char photo, decimal price)
        {
            if (photo == Yes)
            {
                price += (40 * numbers);
            }

            return price;
        }

        private static decimal SelectPrice(string stage, string ticket, decimal price)
        {
            switch (stage)
            {
                case QuarterFinal:
                    switch (ticket)
                    {
                        case Standard:
                            price = StandardQuarterPrice;
                            break;
                        case Premium:
                            price = PremiumQuarterPrice;
                            break;
                        case Vip:
                            price = VipQuarterPrice;
                            break;
                    }
                    break;
                case SemiFinal:
                    switch (ticket)
                    {
                        case Standard:
                            price = StandardSemiPrice;
                            break;
                        case Premium:
                            price = PremiumSemiPrice;
                            break;
                        case Vip:
                            price = VipSemiPrice;
                            break;
                    }
                    break;
                case Final:
                    switch (ticket)
                    {
                        case Standard:
                            price = StnadardFinalPrice;
                            break;
                        case Premium:
                            price = PremiumFinalPrice;
                            break;
                        case Vip:
                            price = VipFinalPrice;
                            break;
                    }
                    break;
            }

            return price;
        }

        const string QuarterFinal = "Quarter final";
        const string SemiFinal = "Semi final";
        const string Final = "Final";
        const string Standard = "Standard";
        const string Premium = "Premium";
        const string Vip = "VIP";
        const char Yes = 'Y';
        const decimal StandardQuarterPrice = 55.5m;
        const decimal StandardSemiPrice = 75.88m;
        const decimal StnadardFinalPrice = 110.10m;
        const decimal PremiumQuarterPrice = 105.2m;
        const decimal PremiumSemiPrice = 125.22m;
        const decimal PremiumFinalPrice = 160.66m;
        const decimal VipQuarterPrice = 118.9m;
        const decimal VipSemiPrice = 300.4m;
        const decimal VipFinalPrice = 400m;
    }
}
