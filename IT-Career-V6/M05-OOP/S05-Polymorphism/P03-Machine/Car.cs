namespace P03_Machine
{
    public class Car : IMachine
    {
        public Car()
        {
            MachineType = nameof(Car);
        }

        public string MachineType { get; set; }

        public bool Start()
        {
            Console.WriteLine("Car starting...");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Car stopping...");
            return true;
        }

    }
}
