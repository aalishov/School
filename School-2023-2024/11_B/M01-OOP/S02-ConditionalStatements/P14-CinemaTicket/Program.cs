namespace P14_CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            double ticketPrice = default(double);

            //Variant 1
            if (day =="Monday" || day == "Tuesday" || day == "Friday")
            {
                ticketPrice = 12;
               
            }
            else if (day =="Wednesday" || day =="Thursday" )
            {
                ticketPrice = 14;
            }
            else 
            {
                ticketPrice = 16;
            }

            //Variant 2
            //switch (day)
            //{
            //    case "Monday":
            //    case "Tuesday":
            //    case "Friday":
            //        ticketPrice = 12;
            //        break;
            //    case "Wednesday":
            //    case "Thursday":
            //        ticketPrice= 14;
            //        break;
            //    default:
            //        ticketPrice = 16;
            //        break;
            //}

            Console.WriteLine($"{ticketPrice}");
         
        }
    }
}