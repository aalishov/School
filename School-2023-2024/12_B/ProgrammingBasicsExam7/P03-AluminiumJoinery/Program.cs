public class Program
{
    public static void Main()
    {
        int countJoinery=int.Parse(Console.ReadLine());

        string type=Console.ReadLine();
        string typeDelivery=Console.ReadLine();
        double price = 0;
        if (countJoinery < 10)
        {
            Console.WriteLine("Invalid order");
            Environment.Exit(0);
        }
        if (type== "90X130" )
        {
            price = 110;
            if (countJoinery > 60)
            {
                price *= 0.92;
            }
            else if (countJoinery>30)
            {
                price *= 0.95;
            }

        }
        else if (type== "100X150")
        {
            price = 140;
            if (countJoinery > 80)
            {
                price *= 0.90;
            }
            else if (countJoinery > 40)
            {
                price *= 0.94;
            }
        }
        else if (type == "130X180")
        {
            price = 190;
            if (countJoinery > 50)
            {
                price *= 0.88;
            }
            else if (countJoinery > 20)
            {
                price *= 0.93;
            }
        }
        else if (type == "200X300")
        {
            price = 250;
            if (countJoinery > 50)
            {
                price *= 0.86;
            }
            else if (countJoinery > 25)
            {
                price *= 0.91;
            }
        }
        double totalSum = price * countJoinery;
        if (typeDelivery=="With delivery")
        {
            totalSum += 60;
        }
        if (countJoinery>=100)
        {
            totalSum *= 0.96;
        }
        Console.WriteLine($"{totalSum:f2} BGN");
    }
}

