using System;
using System.Collections.Generic;
using System.Text;


public class Trainer
{
    //Полета
    private string name;
    private int badgeCount;
    private readonly List<Pokemon> pokemons;

    //Конструктор
    public Trainer()
    {
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

    public void Add(Pokemon pokemon)
    {
        this.pokemons.Add(pokemon);
    }
}


