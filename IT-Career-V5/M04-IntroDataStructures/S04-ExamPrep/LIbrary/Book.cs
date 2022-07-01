using System;
using System.Collections.Generic;
using System.Text;


public class Book
{
    public Book(string id)
    {
        this.Id = id;
    }
    public string Id { get; private set; }
    public Book Next { get; set; }
    public override string ToString()
    {
        return $"Book: {this.Id}";
    }
}

