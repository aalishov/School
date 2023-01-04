using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        List<BaseHero> heroes = new List<BaseHero>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string heroName = Console.ReadLine();
            string heroType = Console.ReadLine();
            BaseHero hero = null;
            switch (heroType)
            {
                case nameof(Druid):
                    hero = new Druid(heroName);
                    break;
                case nameof(Paladin):
                    hero=new Paladin(heroName);
                    break ;
                case nameof(Rogue):
                    hero = new Rogue(heroName);
                    break;
                case nameof(Warrior):
                    hero = new Warrior(heroName);
                    break;
                default:
                    Console.WriteLine("Invalid hero!");
                    break;
            }
            heroes.Add(hero);
        }
        double bossPower=double.Parse(Console.ReadLine());
        double sumPower = heroes.Sum(x => x.Power);
        
        foreach (var hero in heroes)
        {
            Console.WriteLine(hero.CastAbility());
        }
        if (sumPower >= bossPower)
        {
            Console.WriteLine("Victory!");
        }
        else
        {
            Console.WriteLine("Defeat...");
        }
    }
}

