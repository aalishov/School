using System;
using System.Collections.Generic;
using System.Globalization;

namespace P11_Birthdates
{
    public class Program
    {
        private static List<BaseCitizen> citizens = new List<BaseCitizen>();
        private static List<IBirthdate> birthdates = new List<IBirthdate>();
        public static void Main()
        {

            while (true)
            {
                Console.Write("Enter info: ");
                string[] info = Console.ReadLine().Split(' ');
                if (info[0] == "End") { break; }

                switch (info[0])
                {
                    case "Citizen":
                        string citizenId = info[3];
                        string citizenName = info[1];
                        DateTime citizenBirthdate;
                        DateTime.TryParseExact(info[4], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out citizenBirthdate);
                        Citizen citizen = new Citizen(citizenId, citizenName, citizenBirthdate);
                        citizens.Add(citizen);
                        birthdates.Add(citizen);
                        break;
                    case "Pet":
                        string petName = info[1];
                        DateTime petBirthdate;
                        DateTime.TryParseExact(info[2], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out petBirthdate);
                        birthdates.Add(new Pet(petName, petBirthdate));
                        break;
                    case "Robot":
                        citizens.Add(new Robot(info[2], info[1]));
                        break;
                    default:
                        break;
                }
            }

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            foreach (var b in birthdates)
            {
                if (b.Birthdate.Year == year)
                {
                    Console.WriteLine(b.Birthdate.ToString("dd/MM/yyyy"));
                }
            }
        }
    }
}
