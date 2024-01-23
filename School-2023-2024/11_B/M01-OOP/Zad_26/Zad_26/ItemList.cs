namespace Zad_26
{
    public class ItemList
    {
        private List<Item> items = new List<Item>();

        public int Count() { return items.Count; }

        public void Add(Item item)
        {
            items.Add(item);
            items = items
                .OrderBy(x => x.Description)
                .ThenBy(x => x.Price)
                .ToList();
        }
        public Item Get(int index)
        {
            return items[index];
        }
    }
}
