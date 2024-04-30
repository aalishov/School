public class Program
{
    public static void Main()
    {
        try
        {
            List<Car> cars = new List<Car>(); 

            string[] info = File.ReadAllLines("data.txt");

            for (int i = 0; i < info.Length; i += 3)
            {
                string type = info[i];
                string brand = info[i + 1];
                string[] carInfo = info[i + 2].Split(" ");

                switch (type)
                {
                    case "1":
                        cars.Add(new Car(brand, int.Parse(carInfo[0]), int.Parse(carInfo[1]), double.Parse(carInfo[2])));
                        break;
                    case "2":
                        cars.Add(new Truck(brand, int.Parse(carInfo[0]), int.Parse(carInfo[1]), double.Parse(carInfo[2]), int.Parse(carInfo[3])));
                        break;
                }
            }

            foreach (Car car in cars.Reverse<Car>())
            {
                Console.WriteLine(car); 
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); 
        }
    }
}

