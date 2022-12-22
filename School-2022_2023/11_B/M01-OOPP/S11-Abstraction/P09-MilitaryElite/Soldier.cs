using System;
using System.Collections.Generic;
using System.Text;

public abstract class Soldier : ISoldier
{
    protected Soldier(int id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public int Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public override string ToString()
    {
        return $"{this.GetType().Name} {this.Id} {this.FirstName} {this.LastName}";
    }
}
