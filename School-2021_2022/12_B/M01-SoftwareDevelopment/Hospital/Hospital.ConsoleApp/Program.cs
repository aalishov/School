using Hospital.Services;
using System;

namespace Hospital.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DoctorService service = new DoctorService();

            while (true)
            {
                string cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "Add":
                        string name = Console.ReadLine();
                        string position = Console.ReadLine();
                        service.Add(name, position);
                        break;
                    case "Names":
                        var doctors = service.DoctorsNames();
                        Console.WriteLine(string.Join(", ",doctors));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
