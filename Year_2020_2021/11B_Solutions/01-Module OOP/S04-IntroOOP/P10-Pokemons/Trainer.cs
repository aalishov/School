using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Trainer
{
    //Полета
    private string name;
    private int badgeCount;
    private readonly List<Pokemon> pokemons;

    //Конструктор
    public Trainer(string name)
    {
        this.Name = name;
        this.pokemons = new List<Pokemon>();
    }

    //Свойства
    //TODO: Validations
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int BadgeCount
    {
        get { return this.badgeCount; }
        set { this.badgeCount = value; }
    }

    public IReadOnlyCollection<Pokemon> Pokemons
    {
        get { return this.pokemons.AsReadOnly(); }
    }

    public void AddPokemonToTrainer(Pokemon pokemon)
    {
        this.pokemons.Add(pokemon);
    }

    public bool IsHasPokemonWithThisElement(string element)
    {
        foreach (var pokemon in this.Pokemons)
        {
            if (pokemon.Element==element)
            {
                return true;
            }
        }
        return false;
    }

    public void AddBadge()
    {
        this.BadgeCount++;
    }

    public void DecreaseHealth()
    {
        List<Pokemon> pokemonsForRemove = new List<Pokemon>();
        foreach (var pokemon in this.pokemons)
        {
            if (pokemon.Health>10)
            {
                pokemon.Health -= 10;
            }
            else
            {
                pokemonsForRemove.Add(pokemon);
            }
        }
        if (pokemonsForRemove.Any())
        {
            foreach (var pokemon in pokemonsForRemove)
            {
                this.pokemons.Remove(pokemon);
            }
        }
    }
    
    public override string ToString()
    {
        return $"{this.Name} {this.BadgeCount} {this.Pokemons.Count}";
    }
}


