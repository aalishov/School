using System;
using System.Collections.Generic;
using System.Text;


public class Book
{
    private string title;
    private string author;
    private int pubDate;
    private decimal price;
    private string publisher;
    private string discount;



    public Book(string title, string author, int pubDate, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.PubDate = pubDate;
        this.Price = price;
        Publisher = "Unknown";
        Discount = "Unavailable";
    }

    public Book(string title, string author, int pubDate, decimal price, string publisher, string discount) : this(title, author, pubDate, price)
    {
        Publisher = publisher;
        Discount = discount;

    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    public int PubDate
    {
        get { return pubDate; }
        set { pubDate = value; }
    }
    public decimal Price
    {
        get { return price; }
        set { price = value; }
    }

    public string Discount
    {
        get { return discount; }
        set { discount = value; }
    }
    public string Publisher
    {
        get { return publisher; }
        set { publisher = value; }
    }

}

