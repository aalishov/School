using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static readonly Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();
    static void Main()
    {
        //Извикваме метода за създаване на ...
        CreateTrainersAndPokemons();

        Tournament();

        //Извикваме метода за печатане на крайния резултат
        PrintTrainersInfo();

    }

    private static void Tournament()
    {
        while (true)
        {
            string element = Console.ReadLine();

            if (element == "End")
            {
                break;
            }

            foreach (var trainer in trainers)
            {
                bool isToAddBadge = trainer.Value.IsHasPokemonWithThisElement(element);
                if (isToAddBadge)
                {
                    trainer.Value.AddBadge();
                }
                else
                {
                    trainer.Value.DecreaseHealth();
                }
            }
        }
    }

    private static void PrintTrainersInfo()
    {
        foreach (var trainer in trainers.OrderByDescending(x=>x.Value.BadgeCount))
        {
            Console.WriteLine(trainer.Value);
        }
    }

    //Метод за създаване на...
    private static void CreateTrainersAndPokemons()
    {
        // Започваме с безкраен цикъл
        while (true)
        {
            //Четем информация за.....
            string[] info = Console.ReadLine() //Четем ред
                .Split(' ') //Разделяме реда на ...
                .ToArray();

            string trainerName = info[0];
            //Спираме цикъла...
            if (trainerName == "Tournament")
            {
                break;
            }

            string pokemonName = info[1]; //
            string element = info[2];
            int health = int.Parse(info[3]);

            //Създаваме...
            Pokemon pokemon = new Pokemon(pokemonName, element, health);

            //Ако...
            if (!trainers.ContainsKey(trainerName))
            {
                //Създаваме...
                Trainer trainer = new Trainer(trainerName);
                trainers.Add(trainerName, trainer);
            }

            //Добавяме покемон към...
            trainers[trainerName].AddPokemonToTrainer(pokemon);
        }
    }
}

