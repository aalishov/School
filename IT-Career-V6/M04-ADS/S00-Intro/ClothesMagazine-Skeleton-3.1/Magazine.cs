using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ClothesMagazine
{
    public class Magazine
    {
        private  List<Cloth> cloths;

        public Magazine(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            cloths = new List<Cloth>();
        }

        public string Type { get; private set; }
        public int Capacity { get; private set; }

        public void AddCloth(Cloth cloth)
        {
            if (Capacity > cloths.Count)
            {
                cloths.Add(cloth);
            }
        }

        public int GetClothCount()
        {
            return cloths.Count;
        }

        public bool RemoveCloth(string color)
        {
            Cloth c = GetCloth(color);
            return cloths.Remove(c);
        }

        public Cloth GetSmallestCloth()
        {
            return cloths.OrderBy(x => x.Size).FirstOrDefault();
        }

        public Cloth GetCloth(string color)
        {
            return cloths.FirstOrDefault(x => x.Color == color);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Type} magazine contains:");
            cloths.OrderBy(x=>x.Size)
                .ToList()
                .ForEach(x => sb.AppendLine(x.ToString()));
            return sb.ToString().TrimEnd();
        }
    }
}
