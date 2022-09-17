using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        private static List<BaseHero> heroes = new List<BaseHero>();
        public static void Main()
        {
            try
            {
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    string name = Console.ReadLine();
                    string type = Console.ReadLine();
                    BaseHero hero = null;
                    switch (type)
                    {
                        case "Druid": hero = new Druid(name); break;
                        case "Paladin": hero = new Paladin(name); break;
                        case "Rogue": hero = new Rogue(name); break;
                        case "Warrior": hero = new Warrior(name); break;
                        default:
                            Console.WriteLine("Invalid hero!");
                            break;
                    }
                    if (hero != null)
                    {
                        heroes.Add(hero);
                    }
                }
                int bossPower = int.Parse(Console.ReadLine());
                foreach (var hero in heroes)
                {
                    Console.WriteLine(hero);
                }
                if (bossPower <= heroes.Sum(x => x.Power))
                {
                    Console.WriteLine("Victory!");
                }
                else
                {
                    Console.WriteLine("Defeat...");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
