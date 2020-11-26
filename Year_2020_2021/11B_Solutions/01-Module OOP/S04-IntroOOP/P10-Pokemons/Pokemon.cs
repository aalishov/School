using System;
using System.Collections.Generic;
using System.Text;

public class Pokemon
{
    private string name;
    private string element;
    private int health;

    public Pokemon(string name, string element, int health)
    {
        this.Name = name;
        this.Element = element;
        this.Health = health;
    }
    //TODO: Validations
    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Element
    {
        get { return this.element; }
        set { this.element = value; }
    }

    public int Health
    {
        get { return this.health; }
        set { this.health = value; }
    }
}
