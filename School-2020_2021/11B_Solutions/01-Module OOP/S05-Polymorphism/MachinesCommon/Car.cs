namespace MachinesCommon
{
    public class Car : IMachine
    {
        public string MachineType { get; set; }
        public Car()
        {
            this.MachineType = "Car";
        }
        public string Start()
        {
            return "Car starting...";
        }
        public string Stop()
        {
            return "Car stopping...";
        }

    }
}
