using System;
using System.Collections.Generic;
using System.Text;

namespace ClothingMagazine
{
    public class Magazine
    {
        private readonly List<Cloth> clothes;

        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            clothes = new List<Cloth>();
        }

        public string Type { get; private set; }

        public int Capacity { get; set; }

        public List<Cloth> Clothes => clothes;

        public void AddCloth(Cloth cloth)
        {
            if (Capacity < clothes.Count)
            {
                clothes.Add(cloth);
            }
        }
        public bool RemoveCloth(string color)
        {
            Cloth cloth = clothes.FirstOrDefault(c => c.Color == color);
            return clothes.Remove(cloth);
        }

        public Cloth GetSmallestCloth()
        {
            return clothes.OrderBy(c => c.Size).FirstOrDefault();
        }

        public Cloth GetCloth(string color)
        {
            return clothes.FirstOrDefault(c => c.Color == color);
        }

        public int GetClothCount()
        {
            return clothes.Count;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");
            foreach (Cloth cloth in clothes.OrderBy(c => c.Size))
            {
                sb.AppendLine(cloth.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
