namespace P01_FirstWebApp.ViewModels.Items
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IndexVM
    {
        public string Title { get => "My items"; }
        public ICollection<Item> Items
        {
            get =>
                Item.CreateItems();
        }
        public double TotalPrice { get => Items.Sum(x => x.Price); }
    }

    public class Item
    {
        public Item(string name, double price, string createdOn)
        {
            Name = name;
            Price = price;
            CreatedOn = createdOn;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public string CreatedOn { get; set; }

        public static ICollection<Item> CreateItems()
        {
            List<Item> items = new List<Item>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(new Item($"Name{i}",250+i*i,$"{DateTime.UtcNow.AddDays(i).ToShortDateString()}"));
            }
            return items;
        }
    }
}
